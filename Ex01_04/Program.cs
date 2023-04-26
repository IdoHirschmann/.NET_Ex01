namespace Ex01_04;

using System;

// $G$ SFN-017 (-10) The program prints the uppercase sentence for numbers
public class Program
{
    public static void Main()
    {
        string v_Str = getStringFormUser(); 
        isStringPalindromHelper(v_Str);
        isDividedByThree(v_Str);
        numOfUpperCaseLetters(v_Str);
        Console.ReadLine();
    }


    private static string getStringFormUser()
    {
        string v_Str;
        bool v_StrIsValid = false;

        Console.WriteLine("Please enter 6 characters long string (only use letters or numbers):");
        v_Str = Console.ReadLine();


        while (!v_StrIsValid)
        {
            if (v_Str.Length == 6)
            {
                if (char.IsNumber(v_Str[0]))
                {
                    v_StrIsValid = IsStrValidNumber(v_Str);
                }
                else if (char.IsLetter(v_Str[0]))
                {
                    v_StrIsValid = isStrValidString(v_Str);
                }
            }

            if(!v_StrIsValid)
            {
                Console.WriteLine(@"Invalid input!
Please enter 6 characters long string (only use letters or numbers):");
                v_Str = Console.ReadLine();
            }
        }

        return v_Str;
    }
    public static bool IsStrValidNumber(string i_StringToCheck)
    {
        bool v_IsStrValidNumber = true;

        for(int i = 0; i < i_StringToCheck.Length && v_IsStrValidNumber; ++i)
        {
            if(!char.IsNumber(i_StringToCheck[i]))
            {
                v_IsStrValidNumber = false;
            }
        }

        return v_IsStrValidNumber;
    }
    private static bool isStrValidString(string i_StringToCheck)
    {
        bool v_IsStrValidString = true;

        for (int i = 0; i < i_StringToCheck.Length && v_IsStrValidString; ++i)
        {
            if (!char.IsLetter(i_StringToCheck[i]))
            {
                v_IsStrValidString = false;
            }
        }

        return v_IsStrValidString;
    }
    private static void isStringPalindromHelper(string i_StringToCheck)
    {
        if (isStringPalindromRec(i_StringToCheck, 0, i_StringToCheck.Length - 1))
        {
            Console.WriteLine("Its a palindrom!");
        }
        else
        {
            Console.WriteLine("Not a palindrom!");
        }
    }
    private static bool isStringPalindromRec(string i_StringToCheck, int i_LeftIndex, int i_RightIndex)
    {
        if(i_LeftIndex == i_RightIndex)
        {
            return true;
        }
        else if((i_LeftIndex + 1) == i_RightIndex)
        {
            return (i_StringToCheck[i_LeftIndex] == i_StringToCheck[i_RightIndex]);
        }
        else
        {
            if (i_StringToCheck[i_LeftIndex] == i_StringToCheck[i_RightIndex])
            {
               return isStringPalindromRec(i_StringToCheck, i_LeftIndex + 1, i_RightIndex - 1);
            }
        }

        return false;
    }
    private static void isDividedByThree(string i_StringToCheck)
    {
        if(char.IsNumber(i_StringToCheck[0]))
        {
            int.TryParse(i_StringToCheck, out int v_StrAsInt);

            if(v_StrAsInt % 3 == 0)
            {
                Console.WriteLine("The string is number, and it is devided by 3.");
            }
            else
            {
                Console.WriteLine("The string is number, and it is'nt devided by 3.");
            }
        }
        else
        {
            Console.WriteLine("The string is not a number.");
        }
    }
    private static void numOfUpperCaseLetters(string i_StringToCheck)
    {
        int v_UpperCounter = 0;

        if(!char.IsNumber(i_StringToCheck[0]))
        {
            for(int i = 0; i < i_StringToCheck.Length; ++i)
            {
                if(char.IsUpper(i_StringToCheck[i]))
                {
                    v_UpperCounter++;
                }
            }
        }

        string v_NumOfUpperStr = string.Format("The number of upper case letters is: {0}", v_UpperCounter);
        Console.WriteLine(v_NumOfUpperStr);
    }
}