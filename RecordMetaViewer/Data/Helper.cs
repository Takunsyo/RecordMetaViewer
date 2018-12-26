using System.IO;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;

namespace RecordMetaViewer.Data
{
    public static class Helper
    {
        public static readonly Dictionary<int,string> AudioComponentType = new Dictionary<int, string>()
        {
            {0b00000, "Reserved"},
            {0b00001, "1/0Mode(Single mono)"},
            {0b00010, "1/0 + 1/0Mode(Dual mono)"},
            {0b00011, "2/0Mode(Stereo)"},
            {0b00100, "2/1Mode"},
            {0b00101, "3/0Mode"},
            {0b00110, "2/2Mode"},
            {0b00111, "3/1Mode"},
            {0b01000, "3/2Mode"},
            {0b01001, "3/2 + LFEMode(3/2.1Mode)"},
            {0b01010, "3/3.1Mode"},
            {0b01011, "2/0/0-2/0/2-0.1Mode"},
            {0b01100, "5/2.1Mode"},
            {0b01101, "3/2/2.1Mode"},
            {0b01110, "2/0/0-3/0/2-0.1Mode"},
            {0b01111, "0/2/0-3/0/2-0.1Mode"},
            {0b10000, "2/0/0-3/2/3-0.2Mode"},
            {0b10001, "3/3/3-5/2/3-3/0/0.2Mode"},
            {0b10010, "Reserved"},
            {0b10011, "Reserved"},
            {0b10100, "Reserved"},
            {0b10101, "Reserved"},
            {0b10110, "Reserved"},
            {0b10111, "Reserved"},
            {0b11000, "Reserved"},
            {0b11001, "Reserved"},
            {0b11010, "Reserved"},
            {0b11011, "Reserved"},
            {0b11100, "Reserved"},
            {0b11101, "Reserved"},
            {0b11110, "Reserved"},
            {0b11111, "Reserved"}
        };

        public static readonly Dictionary<int,string> VideoComponentType = new Dictionary<int, string>()
        {
            {0x01, "480i(525i), 4:3"},
            {0x02, "480i(525i), 16:9 With Side Panel"},
            {0x03, "480i(525i), 16:9 No Side Panel"},
            {0x04, "480i(525i),  > 16:9"},
            {0x83, "4320p, 16:9"},
            {0x91, "2160p, 4:3"},
            {0x92, "2160p, 16:9 With Side Panel"},
            {0x93, "2160p, 16:9 No Side Panel"},
            {0x94, "2160p,  > 16:9"},
            {0xA1, "480p(525p), 4:3"},
            {0xA2, "480p(525p), 16:9 With Side Panel"},
            {0xA3, "480p(525p), 16:9 No Side Panel"},
            {0xA4, "480p(525p),  > 16:9"},
            {0xB1, "1080i(1125i), 4:3"},
            {0xB2, "1080i(1125i), 16:9 With Side Panel"},
            {0xB3, "1080i(1125i), 16:9 No Side Panel"},
            {0xB4, "1080i(1125i),  > 16:9"},
            {0xC1, "720p(750p), 4:3"},
            {0xC2, "720p(750p), 16:9 With Side Panel"},
            {0xC3, "720p(750p), 16:9 No Side Panel"},
            {0xC4, "720p(750p),  > 16:9"},
            {0xD1, "240p 4:3"},
            {0xD2, "240p 16:9 With Side Panel"},
            {0xD3, "240p 16:9 No Side Panel"},
            {0xD4, "240p  > 16:9"},
            {0xE1, "1080p(1125p), 4:3"},
            {0xE2, "1080p(1125p), 16:9 With Side Panel"},
            {0xE3, "1080p(1125p), 16:9 No Side Panel"},
            {0xE4, "1080p(1125p),  > 16:9"},
            {0xF1, "180p 4:3"},
            {0xF2, "180p 16:9 With Side Panel"},
            {0xF3, "180p 16:9 No Side Panel"},
            {0xF4, "180p  > 16:9"},
        };

        public static readonly Dictionary<int,string> AudioSamplingRate = new Dictionary<int, string>()
        {
            {16000, "16kHz" },
            {22050, "22.05kHz"},
            {24000, "24kHz"},
            {32000, "32kHz"},
            {44100, "44.1kHz"},
            {48000, "48kHz"},
        };

        public static T[] AppendArray<T>(this T[] source, T[] array)
        {
            if (source is null & array is null) return null;
            if (source is null) return array;
            if (array is null) return source;
            int ltmp = source.Length;
            var tmp = source;
            Array.Resize(ref tmp, ltmp + array.Length);
            Array.Copy(array, 0, tmp, ltmp, array.Length);
            return tmp;
        }

        /// <summary>
        /// Get a UNIX Timestamp from a specific DateTime object.
        /// <para>*TimeStamp is counted in milliseconds.</para>
        /// </summary>
        public static long GetUNIXTimeStamp(DateTime time)
        {
            return (long)(time.ToUniversalTime().Subtract(new DateTime(1970, 1, 1))).TotalMilliseconds;
        }

        /// <summary>
        /// Get current time UNIX Timestamp.
        /// <para>*TimeStamp is counted in milliseconds.</para>
        /// </summary>
        public static long GetUNIXTimeStamp()
        {
            return GetUNIXTimeStamp(DateTime.Now);
        }

        /// <summary>
        /// Get a <see cref="DateTime"/> object from a UNIX TimeStamp.
        /// </summary>
        /// <param name="UNIXTimeStamp">The TimeStamp are Mirakurun server is using counted in milliseconds.</param>
        /// <returns></returns>
        public static DateTime GetDateTime(long UNIXTimeStamp)
        {
            return new DateTime(1970, 1, 1).AddMilliseconds(UNIXTimeStamp);
        }

        public static IEnumerable<Channel> GetChannels()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ChannelPrefix.json");
            IEnumerable<Channel> retObj;
            if (File.Exists(path))
            {
                var prefexStr = "";
                using (var reader = File.OpenText(path))
                {
                    prefexStr = reader.ReadToEnd();
                }
                if (!string.IsNullOrWhiteSpace(prefexStr))
                {
                    try
                    {
                        retObj = JsonConvert.DeserializeObject<IEnumerable<Channel>>(prefexStr);
                        return retObj;
                    }
                    catch
                    {
                    }
                }
            }
            var Str = Properties.Resources.ChannelPrefix;
            retObj = JsonConvert.DeserializeObject<IEnumerable<Channel>>(Str);
            return retObj;
        }


        public static IEnumerable<Channel> Channels { get; set; }

        public static string GetChannelName(long id)
        {
            return Channels.First(x => x.id == id)?.name;
        }
    }
}

