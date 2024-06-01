using System;

namespace BigMission.DeviceApp.Shared
{
    public class ChannelMappingDto
    {
        /// <summary>
        /// Mappings's PK ID.
        /// </summary>
        public int Id { get; set; }
        public int DeviceAppId { get; set; }
        public string ReservedName { get; set; }
        public string ChannelName { get; set; }
        public uint CanId { get; set; }
        public byte Offset { get; set; }
        public byte Length { get; set; }

        /// <summary>
        /// AND Mask.
        /// </summary>
        public uint Mask { get; set; }
        public string SourceType { get; set; }
        public bool IsBigEndian { get; set; }

        // Formula: RAW * [Multipler] / [Divider] + [Const]
        public double FormulaMultipler { get; set; }
        public double FormulaDivider { get; set; }
        public double FormulaConst { get; set; }
        public string Conversion { get; set; }
        public double LowRange { get; set; }
        public double HighRange { get; set; }

        /// <summary>
        /// Indicates whether this is data originating from outside the car
        /// and is going to be sent to the car onto the CAN bus.
        /// </summary>
        public bool IsVirtual { get; set; }

        /// <summary>
        /// How often the data is to be sent to the CAN Bus.
        /// Only applies to virtual channels.
        /// </summary>
        public int VirtualFrequencyMs { get; set; }
    }
}
