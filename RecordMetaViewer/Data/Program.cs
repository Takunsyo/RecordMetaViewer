using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace RecordMetaViewer.Data
{
    /// <summary>
    /// EPGStation API
    /// 'server addr'/recorded/{id}
    /// Object"ReserveProgram"
    /// </summary>
    public class Program
    {
        #region Data feilds
        public int code { get; set; }
        public string message { get; set; }
        public string errors { get; set; }
        public long id { get; set; }
        public long startAt { get; set; }
        public long endAt { get; set; }
        public bool isFree { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string extended { get; set; }
        public int genre1 { get; set; }
        public int genre2 { get; set; }
        public ChannelType channelType { get; set; }
        public string videoType { get; set; }
        public string videoResolution { get; set; }
        public int videoStreamContent { get; set; }
        public int videoComponentType { get; set; }
        public int audioSamplingRate { get; set; }
        public int audioComponentType { get; set; }
        public bool recording { get; set; }
        public bool protection { get; set; }
        public long filesize { get; set; }
        public int errorCnt { get; set; }
        public int dropCnt { get; set; }
        public int scramblingCnt { get; set; }
        public bool hasThumbnail { get; set; }
        public bool original { get; set; }
        public string filename { get; set; }
        //public dynamic encoded { get; set; } //not needed
        //public dynamic encoding { get; set; }//not needed
        public bool overlap { get; set; }
        public long channelId { get; set; }
        public int eventId { get; set; }
        public int serviceId { get; set; }
        public int networkId { get; set; }
        public string channel { get; set; }
        #endregion

        public bool IsOnGoing
        {
            get
            {
                var tnow = Helper.GetUNIXTimeStamp();
                return (this.startAt <= tnow) && (this.endAt > tnow);
            }
        }

        public ProgramGenre Genre => (ProgramGenre)(1 << this.genre1);

        public string GenreString => (1 << this.genre1).GetDescription<ProgramGenre>();

        public string SubGenre => (1 << this.genre2).GetDescription(this.Genre);

        public string ChannelName => Helper.GetChannelName(channelId);

        public string Length
        {
            get
            {
                var len = (this.endAt - this.startAt) / 1000/60;
                switch (len)
                {
                    case long sec when sec < 60:
                        return $"[{sec.ToString("D2")}分]";
                    default:
                        var h = len / 60;
                        var s = len - (h * 60);
                        return $"[{h.ToString("D2")}時間" + (s == 0 ? "" : $"{s.ToString("D2")}分") + "]";
                }
            }
        }

        public string StartAt
        {
            get
            {
                var ti = Helper.GetDateTime(this.startAt);
                ti = ti.ToLocalTime();
                var cul = CultureInfo.InstalledUICulture;
                return ti.ToString("F",cul);
            }
        }
        #region Data Serializetion
        public byte[] Serialize()
        {
            var jStr = JsonConvert.SerializeObject(this,
                Formatting.None,
                new JsonSerializerSettings
                { //Ignore null properties to save space.
                    NullValueHandling = NullValueHandling.Ignore
                });
            return System.Text.Encoding.UTF8.GetBytes(jStr);
        }
        public static Program Deserialize(byte[] data)
        {
            var jStr = System.Text.Encoding.UTF8.GetString(data);
            return JsonConvert.DeserializeObject<Program>(jStr);
        }
        #endregion
    }
}
