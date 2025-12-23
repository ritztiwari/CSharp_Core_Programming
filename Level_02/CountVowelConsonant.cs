//Write a C# program to count the number of vowels and consonants in a given string.

public class CountVowelConsonant
{
    public static bool CheckVowels(char s)
    {
        return "aeiouAEIOU".IndexOf(s) != -1;
    }

    public static void Count()
    {
        Console.WriteLine("enter the sentence:");
        string s = Console.ReadLine() ?? "";

        int vowels = 0;
        int consonants = 0;

        for(int i = 0; i < s.Length; i++)
        {
            if (CheckVowels(s[i]))
            {
                vowels++;
            }
            else if (s[i] != ' ')
            {
                consonants++;
            }
        }

        Console.WriteLine($"\n no. of vowels are {vowels}\n no.of consonants are {consonants}");
    }
}