namespace UOS.Client.Types.Enums;

public static class TerminalErrorConverter
{
    public static string ToString(TerminalError error)
    {
        switch (error)
        {
            case TerminalError.ConnectionFailed:
                return "\"Network connection not found\"\n\"Dummy terminal inactive.\"";
            case TerminalError.PowerFailure:
                return "\"Primary power source unavailable\"\n\"Check all coords and plugs for connection.\"";
            case TerminalError.BadData:
                return "\"Bad data. Cannot read.\"";
            case TerminalError.NoInput:
                return "\"No Input Device Recognized.\"\n\"Reconnect Keyboard.\"";
            case TerminalError.CorruptProcessor:
                return "\"Processor\nCorru;xsfkleg,,g364[735}3__.\"";
            case TerminalError.NoStorage:
                return "\"No Data Storage Detected.\"\n\"Check Tape Drive Connection.\"";
            case TerminalError.BadSector:
                return "\"Bad Sectors Found In Boot Block.\"\n\"Terminal Error.\"";
            case TerminalError.SegmentationFault:
                return "\"Segmentation Fault.\"";
            case TerminalError.MemoryFault:
                return "\"Memory Fault.\"";
            case TerminalError.CriticalFailure:
                return "\"Critical Failure.\"";
            case TerminalError.InvalidRequest:
                return "\"Invalid Request.\"";
            default:
                return "\"Unknown Error.\"";
        }
    }
}