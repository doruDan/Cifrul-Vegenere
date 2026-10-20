using Cifrul_Viginere.Methods;

char[] alphabet = "AĂÂBCDEFGHIÎJKLMNOPQRSȘTȚUVWXYZ".ToCharArray();
int alphabetLength = alphabet.Length;
int userChoice = 0;
string userInput = "";
string key = "";

Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;
bool running = true;

while (running)
{
    string solution = "";

    Console.WriteLine("Ce doriți să faceți?");
    Console.WriteLine("1.Cifrare");
    Console.WriteLine("2.Decifrare");
    Console.WriteLine("0.Ieșire");
    userChoice = InputHelpers.ValidatingUserChoice();  // Validating user option//

    if (userChoice == 0)
    {
        running = false;
        continue;
    }

    Console.WriteLine("Introduceți textul:");
    userInput = InputHelpers.ValidatingUserInput();    //Accepting user text//

    Console.WriteLine("Introduceți cheia:");
    key = InputHelpers.ValidatingKey();    //Accepting user key//

    userInput = userInput.Replace(" ", string.Empty);
    char[] cutInput = userInput.ToCharArray();
    char[] cutKey = key.ToCharArray();

    if (userChoice == 1) //Code block for cyphering
    {
        int inputLetterIndex = 0;
        int keyLetterIndex = 0;
        int keyIndex = 0;
        foreach (char letter in cutInput) 
        {
            char keyLetter = cutKey[keyIndex % cutKey.Length];
            
            inputLetterIndex = Array.IndexOf(alphabet, letter);
            keyLetterIndex = Array.IndexOf(alphabet, keyLetter);
                
            solution += alphabet[(inputLetterIndex + keyLetterIndex) % alphabetLength];

            keyIndex++;
        }
        Console.WriteLine($"\nRezultat: {solution}\n");
    }
    else //Code block for decyphering
    {
        int inputLetterIndex = 0;
        int keyLetterIndex = 0;
        int keyIndex = 0;
        foreach (char letter in cutInput)
        {
            char keyLetter = cutKey[keyIndex % cutKey.Length];

            inputLetterIndex = Array.IndexOf(alphabet, letter);
            keyLetterIndex = Array.IndexOf(alphabet, keyLetter);

            solution += alphabet[(inputLetterIndex - keyLetterIndex + alphabetLength) % alphabetLength];

            keyIndex++;
        }
        Console.WriteLine($"\nRezultat: {solution}\n");
    }
}