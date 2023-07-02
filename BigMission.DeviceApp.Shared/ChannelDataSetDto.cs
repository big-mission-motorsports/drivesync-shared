using Newtonsoft.Json;
using System;

namespace BigMission.DeviceApp.Shared
{
    public class ChannelDataSetDto
    {
        [JsonProperty("id")]
        public int DeviceAppId { get; set; }
        [JsonProperty("t")]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Indicates whether these channels are virtual updates.  Otherwise,
        /// they originated in the car.
        /// </summary>
        [JsonProperty("v")] 
        public bool IsVirtual { get; set; }

        [JsonProperty("d")]
        public ChannelStatusDto[] Data { get; set; }
    }
}
