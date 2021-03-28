using Newtonsoft.Json;
using System;

namespace BigMission.DeviceApp.Shared
{
    public class ChannelStatusDto
    {
        [JsonProperty("t")]
        public DateTime Timestamp { get; set; }
        [JsonProperty("did")]
        public int DeviceAppId { get; set; }
        [JsonProperty("cid")]
        public int ChannelId { get; set; }
        [JsonProperty("v")]
        public float Value { get; set; }
    }
}
