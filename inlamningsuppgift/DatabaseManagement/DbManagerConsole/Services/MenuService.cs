using System.Diagnostics;

//TODO: Unit test av nått slag
namespace DbManagerConsole.Services {
    internal class MenuService() {
        private static readonly IReadOnlyList<string> _exitStrings = ["q", "quit", "e", "exit"];
        private static readonly IReadOnlyList<string> _yesStrings = ["y", "yes", "1", "true"];

        /// <summary>
        /// The main menu loop, loops forever until user exits app
        /// </summary>
        public void StartMenuLoop() {
            while (true) {
                Console.Clear();
                DrawLine();
                Console.WriteLine(" 1. Add");
                Console.WriteLine(" 2. Remove");
                Console.WriteLine(" 3. ReadOne");
                Console.WriteLine(" 4. ReadAll");
                Console.WriteLine(" Q. Exit");
                DrawLine('=');
                Console.WriteLine("");

                var selection = RequestInput(":", true, true);

                //Check if user wants to exit app
                if (_exitStrings.Contains(selection)) { return; }

                Console.Clear();

                switch (selection) {
                    //Add contact
                    case "1":

                        break;

                    //Remove contact
                    case "2":

                        break;

                    //List all contact info
                    case "3":

                        break;

                    //Open folder
                    case "4":

                        break;

                    default:
                        continue;
                }
            };
        }

        #region ShowMenu Methods

        private void ShowMenuAdd() {

        }

        #endregion

        #region Display methods

        private void Display() {

        }

        #endregion

        #region Helper methods

        /// <summary>
        /// Requests input from user<br/>
        /// Will accept empty input if not 'required'
        /// </summary>
        /// <param name="displayText">Text explaining to the user what's expected</param>
        /// <param name="required">If true user needs to give non-empty input</param>
        /// <param name="lowercase">If true return value is made lowercase</param>
        /// <returns>User's input, or empty string if no input given</returns>
        private static string RequestInput(string displayText, bool required = false, bool lowercase = false) {
            Console.Write(displayText);
            string tInput;

            while (string.IsNullOrWhiteSpace(tInput = Console.ReadLine()!.Trim())) {
                if (!required) return "";

                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Write(displayText);
            }

            if (lowercase) return tInput.ToLower(); else return tInput;
        }

        /// <summary>
        /// Standard "Press any key to continue" thing
        /// </summary>
        private static void AnyKeyToContinue() {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey(true);
        }

        /// <summary>
        /// Draws a decorative line to the console
        /// </summary>
        /// <param name="typedChar">Character to repeat</param>
        /// <param name="numChars">How many characters to write</param>
        private static void DrawLine(char typedChar = '~', int numChars = 50) {
            Console.WriteLine(new string(typedChar, numChars));
        }

        #endregion
    }
}
