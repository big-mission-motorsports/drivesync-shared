namespace BigMission.Drivesync.Shared;

/// <summary>
/// Types of CAN bus data representations.
/// </summary>
public class ChannelSourceType
{
    public const string UNSIGNED = "Unsigned";
    public const string SIGNED = "Signed";
    public const string FLOAT = "Float";
    public const string SIGN_MAGNITUDE = "SignMagnitude";

    public static string[] Types = new string[]
    {
        UNSIGNED,
        SIGNED,
        FLOAT,
        SIGN_MAGNITUDE
    };
}