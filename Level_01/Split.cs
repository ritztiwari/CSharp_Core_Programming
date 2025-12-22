//11. Split Text into Words and Display Word Lengths

using System;

public class Split
{
    static int GetStringLength(string s)
    {
        int count = 0;
        foreach (char c in s)
            count++;
        return count;
    }

    static string[,] SplitWordsWithLength(string text)
    {
        string[] tempWords = new string[100];
        int wordCount = 0;
        string currentWord = "";

        for (int i = 0; i < GetStringLength(text); i++)
        {
            if (text[i] != ' ')
            {
                currentWord += text[i];
            }
            else if (currentWord != "")
            {
                tempWords[wordCount++] = currentWord;
                currentWord = "";
            }
        }

        if (currentWord != "")
            tempWords[wordCount++] = currentWord;

        string[,] result = new string[wordCount, 2];

        for (int i = 0; i < wordCount; i++)
        {
            result[i, 0] = tempWords[i];
            result[i, 1] = GetStringLength(tempWords[i]).ToString();
        }

        return result;
    }

    public static void SplitWord ()
    {
        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine() ?? "";

        string[,] data = SplitWordsWithLength(input);

        Console.WriteLine("\nWord\tLength");
        for (int i = 0; i < data.GetLength(0); i++)
        {
            Console.WriteLine(data[i, 0] + "\t" + data[i, 1]);
        }
    }
}
