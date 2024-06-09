namespace FortuneTeller
{
    /// <summary>
    /// This class will process the input 
    /// </summary>
    public class ProcessUsers
    {
        private readonly IConsoleDisplay display;

        /// <summary>
        ///  Consturctor for Process User 
        /// </summary>
        /// <param name="display">Display object</param>
        public ProcessUsers(IConsoleDisplay display)
        {
            this.display = display;
        }
        // 12345678901234567890123456789012345678901234567890123456789012345678901234567890

        /// <summary>
        /// Start the Process until exiting
        /// </summary>
        public void StartProcess()
        {
            // Here in loop forever
            while (true)
            {
                int controlDisplay = 0;
                User user = new User();
                // loop here until controlDisplay > 6
                while (true)
                {
                    try
                    {
                        //Use switch to control prompt until a valid response 
                        switch (controlDisplay)
                        {
                            case 0:
                                display.ClearScreen("Type quit to Exit the program");
                                break;
                            case 1:
                                user.FirstName = display.PromptInput("First Name:");
                                break;
                            case 2:
                                user.LastName = display.PromptInput("Last Name:");
                                break;
                            case 3:
                                user.Age = int.Parse(display.PromptInput("Age:", true));
                                break;
                            case 4:
                                user.BirthMonth = int.Parse(display.PromptInput("Birth Month:", true));
                                break;
                            case 5:
                                user.Siblings = int.Parse(display.PromptInput("How many Siblings:"));
                                break;
                            case 6:
                                user.FavoriteColor = ParseEnum(display.PromptInput("Favorite Color:", false, GetColorString()));
                                break;
                        }
                        controlDisplay++;
                        if (controlDisplay > 6)
                        {
                            break;
                        }
                    }
                    catch (ValidateException ve)
                    {
                        display.WriteLine();
                        display.WriteLine(ve.Message);
                        display.WriteLine();
                    }
                    catch (Exception ex)
                    {
                        display.WriteLine();
                        display.WriteLine(ex.Message);
                        display.WriteLine();
                    }
                }
                UserFortune userFortune = new UserFortune(user);
                display.ClearScreen("Your Fortune is..");
                string s = $"{user.FirstName} {user.LastName} will retire in {userFortune.Retirement} years, with {userFortune.Balance} in the bank, a vacation home in {userFortune.Location}, and travel by {userFortune.Transport}";
                display.WriteLine(s);
                display.WriteLine();
                display.ReadLine();
            }
        }
        /// <summary>
        /// Gets the string values of an Enum
        /// </summary>
        /// <returns>a delimted string of colors</returns>
        private string GetColorString()
        {
            string retValue = "The Colors are: ";
            for (int x = 0; x < (int)RoygbivEnum.Max; x++)
            {
                retValue += $"{(RoygbivEnum)x}, ";
            }

            return retValue;
        }

        /// <summary>
        /// Converts a string into an Enum value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="ValidateException"></exception>
        private RoygbivEnum ParseEnum(string value)
        {
            try
            {
                return (RoygbivEnum)Enum.Parse(typeof(RoygbivEnum), value, true);
            }
            catch
            {
                throw new ValidateException("Color not found");
            }
        }

    }
}
