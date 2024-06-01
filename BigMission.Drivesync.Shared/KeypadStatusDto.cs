using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BigMission.Drivesync.Shared;

public class KeypadStatusDto
{
    [JsonProperty("id")]
    public int DeviceAppId { get; set; }
    [JsonProperty("kid")]
    public int KeypadId { get; set; }
    [JsonProperty("t")]
    public DateTime Timestamp { get; set; }
    [JsonProperty("lss")]
    public List<KeypadLedState> LedStates { get; set; } = new List<KeypadLedState>();
}

public class KeypadLedState
{
    [JsonProperty("b")]
    public int ButtonNumber { get; set; }
    [JsonProperty("lp")]
    public int LedPos { get; set; }
    [JsonProperty("ls")]
    public int LedState { get; set; }
}
