namespace UOS.Client.Types.Enums;

public enum TerminalError : uint
{
    ConnectionFailed = 0x03c663a1,
    PowerFailure = 0x0aabff00,
    BadData = 0x07f6baac,
    NoInput = 0x00b636c6,
    CorruptProcessor = 0xfffff710,
    NoStorage = 0xf141a013,
    BadSector = 0x357c5001,
    SegmentationFault = 0xfa770171,
    MemoryFault = 0xfff11011,
    CriticalFailure = 0x00001001,
    InvalidRequest = 0xa001c007
}