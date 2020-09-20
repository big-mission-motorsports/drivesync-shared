using System;

namespace BigMission.DeviceApp.Shared
{
    public class ChannelStatusDto
    {
        public DateTime Timestamp { get; set; }
        public int DeviceAppId { get; set; }
        public int ChannelId { get; set; }
        public float Value { get; set; }
    }
}
