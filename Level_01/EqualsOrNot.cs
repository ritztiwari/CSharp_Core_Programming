//Compare Two Strings Using charAt()

using System;

public class EqualsOrNot
{
    public static bool checkString(string str1, string str2)
    {
        if(str1.Length != str2.Length)
        {
            return false;
        }

        for(int i = 0; i < str1.Length; i++)
        {
            if( str1[i] != str2[i])
            {
                return false; 
            }
        }

        return true;
    }

    public static void Check()
    {
        string input1 = Console.ReadLine() ?? "";
        string input2 = Console.ReadLine() ?? "";

        bool result1 = checkString(input1, input2);
        bool result2 = string.Equals (input1, input2);
        Console.WriteLine(result1 && result2);

    }
}