using static InputProcessing;

/*
Currently using named parameters


InputValidation parameters:
is not empty;
is string;
contains punctuation;
contains spaces;
contains capitals;
contains numbers;


InputFormatting parameters:
remove punctuation;
remove spaces;
remove capitals;
remove numbers;

*/

string plaintext;
do
{
    Console.WriteLine("enter text here");
    plaintext = Console.ReadLine();
    // actually run inputvalidation inside here

} while (InputValidation(plaintext) != true);

InputValidation(plaintext);
InputValidation(plaintext, isNotEmpty:true);
InputValidation(plaintext, isString:true, isNotEmpty:true);

class InputProcessing
{
    public static bool InputValidation(string inputText, bool isNotEmpty = false, bool isString = false)
    {
        if (isNotEmpty == true)
        {
            Console.WriteLine("testing for empty string");
            return false;
        }

        if (isString == true)
        {
            Console.WriteLine("testing for string type");
            return false;
        }

        Console.WriteLine("Input is acceptable");
        return true;
    }

    public void InputFormatting(string inputText, bool punctuation = false, bool spaces = false, bool capitals = false, bool numbers = false)
    {

    }

}