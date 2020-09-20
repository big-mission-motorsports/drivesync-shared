using System;
using System.Collections.Generic;
using System.Text;

namespace BigMission.DeviceApp.Shared
{
    public class DeviceAppHeartbeatDto
    {
        public int DeviceAppId { get; set; }
        public DateTime Timestamp { get; set; }
        public Guid ConfigurationId { get; set; }
    }
}
