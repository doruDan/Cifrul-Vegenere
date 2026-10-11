using System;
using System.Collections.Generic;
using System.Text;

namespace Cifrul_Viginere.Methods
{
    internal class InputHelpers
    {
        public static int ValidatingUserOption() //metoda validează alegerea utilizatorului
        {
            int userChoice;
            while (!int.TryParse(Console.ReadLine(), out userChoice) || userChoice != 1 && userChoice != 0)
            {
                Console.WriteLine("Alegeți fie 0 sau 1.");
            }
            return userChoice;
        }

        public static int ValidatingUserChoice() //metoda validează alegerea utilizatorului
        {
            int userChoice;
            while (!int.TryParse(Console.ReadLine(), out userChoice) || userChoice != 1 && userChoice != 2)
            {
                Console.WriteLine("Alegeți fie 1 sau 2.");
            }
            return userChoice;
        }

        public static string ValidatingUserInput() // validează mesajul introdus de utilizator
        {
            string userInput = Console.ReadLine().ToUpper();

            while (string.IsNullOrWhiteSpace(userInput) || !userInput.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                Console.WriteLine("Introduceți un text care să conțină doar litere cuprinse în diapazoanele A și Z, a și z");
                userInput = Console.ReadLine().ToUpper();
            }

            return userInput;
        }

        public static string ValidatingKey() // validează cheia introdusă de utilizator
        {
            string userSecondKey = Console.ReadLine().ToUpper();

            while (string.IsNullOrWhiteSpace(userSecondKey) || !userSecondKey.All(char.IsLetter) || userSecondKey.Length < 7)
            {
                Console.WriteLine("Introduceți un text care să conțină doar litere cuprinse în diapazoanele A și Z, a și z și să aibă o lungime de cel puțin 7 litere.");
                userSecondKey = Console.ReadLine().ToUpper();
            }

            return userSecondKey;
        }
    }
}
