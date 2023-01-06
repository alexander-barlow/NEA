
//converts int array to char array and outputs it
public static class LetterConvert
{
    public static void outputCharArray(int[] array)
    {
        char[] charArray = new char[26];
        

        for (int i = 0; i < array.Length; i++)
        {
            charArray[i] = (char)array[i];
        }
        Console.WriteLine("\n");
        Console.WriteLine(string.Join(" ", charArray));
    }
}    
