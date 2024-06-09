namespace FortuneTeller
{
    /// <summary>
    /// This class handles the Console display methods
    /// </summary>
    /// <remarks>Used as a Wraper around the Console methods to make testing easier</remarks>
    public class ConsoleDisplay : IConsoleDisplay
    {
        private readonly string title;

        /// <summary>
        /// Consturctor for Console Display
        /// </summary>
        /// <param name="title">Will be used after ever clear screen</param>
        public ConsoleDisplay(string title)
        {
            this.title = title;
        }

        /// <summary>
        /// Clears the screen and displays a prompt
        /// </summary>
        /// <param name="prompt"></param>
        public void ClearScreen(string prompt = "")
        {
            Console.Clear();
            Console.WriteLine(title);
            Console.WriteLine();
            if (!string.IsNullOrEmpty(prompt))
            {
                Console.WriteLine(prompt);
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Gets input from user base on a display value
        /// </summary>
        /// <param name="display">Display value.</param>
        /// <returns>Keyborad input.</returns>
        public string PromptInput(string display, bool isInteger = false, string helpMessage= "")
        {
            //Initialize return value
            string retValue = string.Empty;
            //Display prompt
            Console.Write($"{display}? ");

            string lineInput = string.Empty;

            //loop until a user inputs a value
            while (string.IsNullOrEmpty(retValue))
            {

                // Get keyboard input
                lineInput = this.ReadLine();
                ///Check to see if help needed
                if (lineInput is not null && lineInput.ToUpper() == "HELP")
                {
                    lineInput= "";
                    if(!string.IsNullOrEmpty(helpMessage))
                        Console.WriteLine(helpMessage);
                }
                // check if the user wants to exit
               else if (lineInput is not null && lineInput.ToUpper() == "QUIT")
                {
                    Console.WriteLine();
                    Console.WriteLine("Nobody likes a quitter...");
                    Environment.Exit(0);
                }
                // checks input for value
                if (!string.IsNullOrEmpty(lineInput))
                {
                    retValue = lineInput;
                }
                else
                {
                    //Display prompt
                    Console.WriteLine($"Invalid input.");
                    Console.Write($"{display}? ");
                }

                // Check for int value
                if (isInteger)
                {
                    int intValue;
                    // if not an value then set retValue to empty and try again.
                    if (!int.TryParse(lineInput, out intValue))
                    {
                        retValue = string.Empty;
                    }
                }
            }
            // return value.
            return retValue;
        }

        /// <summary>
        /// Writes a line to the Console output
        /// </summary>
        /// <param name="line">String to display</param>
        public void WriteLine(string? line = null)
        {
            Console.WriteLine(line);
        }

        /// <summary>
        /// Writes a line to the Console output
        /// </summary>
        /// <param name="line"></param>
        public void Write(string line)
        {
            Console.Write(line);
        }

        /// <summary>
        /// Reads a line from the keyboard.
        /// </summary>
        /// <returns>String</returns>
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
