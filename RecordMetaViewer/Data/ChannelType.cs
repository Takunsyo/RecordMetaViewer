using System.ComponentModel;

namespace RecordMetaViewer.Data
{
    /// <summary>
    /// The enum dedicate to signal types.
    /// </summary>
    public enum ChannelType
    {
        /// <summary>
        /// Ground radio signals.
        /// </summary>
        [Description("地上波")]
        GR,
        /// <summary>
        /// Broadcasting satellites signals. (110°)
        /// </summary>
        [Description("BS衛星放送")]
        BS,
        /// <summary>
        /// Communication satellites signals. (110°)
        /// </summary>
        [Description("CS衛星放送")]
        CS,
        /// <summary>
        /// Sky perfect specific broadcasting signals. (mostly in 128° broadcasting satellites)
        /// </summary>
        [Description("スカパー")]
        SKY
    }
}
