namespace FortuneTeller
{
    /// <summary>
    /// Use this for mocing console I/O
    /// </summary>
    public interface IConsoleDisplay
    {
        void ClearScreen(string prompt = "");
        string PromptInput(string display, bool isInteger = false, string helpMessage = "");
        string ReadLine();
        void Write(string line);
        void WriteLine(string? line = null);
    }
}