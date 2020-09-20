using System;
using System.Collections.Generic;
using System.Text;

namespace BigMission.DeviceApp.Shared
{
    public class ChannelDataSetDto
    {
        public int DeviceAppId { get; set; }
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Indicates whether these channels are virtual updates.  Otherwise,
        /// they originated in the car.
        /// </summary>
        public bool IsVirtual { get; set; }

        public ChannelStatusDto[] Data { get; set; }
    }
}
