namespace UOS.Client.Types;

public class RobcoButtonEntry
{
    public string Text { get; set; } = ">!INVALID!<";
    public bool FinishedRendering { get; set; } = false;
    public int State { get; set; } = -1;
    public string? Url { get; set; } = null;
    public bool Selected { get; set; }
    public string Class => Selected ? "robco-hovered" : "";

    public RobcoButtonEntry()
    {
    }

    public RobcoButtonEntry(string text, int state)
    {
        Text = text;
        State = state;
    }

    public RobcoButtonEntry(string text, string? url)
    {
        Text = text;
        Url = url;
    }
}