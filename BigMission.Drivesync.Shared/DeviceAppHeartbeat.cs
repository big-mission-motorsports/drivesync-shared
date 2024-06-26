﻿using Newtonsoft.Json;
using System;

namespace BigMission.Drivesync.Shared;

public class DeviceAppHeartbeat
{
    [JsonProperty("dk")]
    public Guid DeviceKey { get; set; }
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
    [JsonProperty("v")]
    public string Version { get; set; }
    [JsonProperty("ip")]
    public string Ip { get; set; }
}
