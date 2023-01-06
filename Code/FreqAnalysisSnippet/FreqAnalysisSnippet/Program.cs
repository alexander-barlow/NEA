using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Bubblesort;
using static LetterConvert;
using static ArrayExtensions;
using static StringExtension;

//input cipher text
Console.WriteLine("Enter Text:");
string cipherText = Console.ReadLine();


//remove capitalisation
string lowerText = cipherText.ToLower();
//Console.WriteLine(lowerText, "\n");


//remove spaces & punctuation
string cleanText = lowerText.Strip();
//Console.WriteLine(cleanText, "\n");


//create letter array & count characters
int[] letterName = new int[26];
for (int i = 0; i < 26; i++)
{
    letterName[i] = i + 97;
}


//count character frequency
int[] letterCount = new int[26];
foreach (char c in cleanText)
{
    letterCount[c - 97] += 1;
}


//output letterCount
//outputCharArray(letterName);
//Console.WriteLine(string.Join(" ", letterCount));


//bubble sort the letterCount list
//apply the same operations to the letterName list to keep the letters and frequencies matched up
(letterName,letterCount) = BubbleSort(letterName, letterCount);


//output letterCount
outputCharArray(letterName);
Console.WriteLine(string.Join(" ", letterCount));


