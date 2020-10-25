using System;

namespace BigMission.DeviceApp.Shared
{
    public class CanAppConfigDto
    {
        /// <summary>
        /// Configuration's PK ID.
        /// </summary>
        public int Id { get; set; }
        public int DeviceAppId { get; set; }
        public Guid ConfigurationId { get; set; }
        public string KafkaConnectionString { get; set; }
        public string KafkaDataTopic { get; set; }
        public string KafkaHeartbeatTopic { get; set; }
        public string KafkaCommandTopic { get; set; }
        public string CanCmd { get; set; }
        public string CanArg { get; set; }
        public string CanBitrate { get; set; }
        public int HeartbeatFrequencyMs { get; set; }
        public int StandardUpdateFrequencyMs { get; set; }
        public int FullUpdateFrequencyMs { get; set; }

        public ChannelMappingDto[] ChannelMappings { get; set; }
        public string DeviceAppKey { get; set; }
    }
}
