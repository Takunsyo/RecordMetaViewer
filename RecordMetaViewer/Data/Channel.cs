

namespace RecordMetaViewer.Data
{
    public class Channel
    {
        public long id { get; set; }
        public int serviceId { get; set; }
        public int networkId { get; set; }
        public string name { get; set; }
        public int remoteControlKeyId { get; set; }
        public bool hasLogoData { get; set; }
        public ChannelType channelType { get; set; }
        public string channel { get; set; }
        public int type { get; set; }
    }
}
