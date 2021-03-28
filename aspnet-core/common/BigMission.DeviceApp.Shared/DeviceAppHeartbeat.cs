using Newtonsoft.Json;
using System;

namespace BigMission.DeviceApp.Shared
{
    public class DeviceAppHeartbeat
    {
        [JsonProperty("id")]
        public int DeviceAppId { get; set; }
        [JsonProperty("ts")]
        public DateTime Timestamp { get; set; }
        [JsonProperty("cid")]
        public Guid ConfigurationId { get; set; }
        [JsonProperty("cpu")]
        public string CpuUsage { get; set; }
        [JsonProperty("ll")]
        public string LogLevel { get; set; }
        [JsonIgnore]
        public string Logs { get; set; }
    }
}
