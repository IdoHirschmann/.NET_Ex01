namespace Ex01_05;

using System;
using System.Diagnostics.Metrics;
using System.Text;

// $G$ SFN-019 (-5) The program does not handle invalid inputs, negative numbers like -123456 are not accepted
class Program
{
    public static void Main()
    {
        int v_Number = getNumberFromUser();

        howManyDigitsBiggerThanUnits(v_Number);
        findMinDigit(v_Number);
        howManyDigitsDividedByThree(v_Number);
        calcDigitsAvarege(v_Number);
        Console.ReadLine();
    }

    private static int getNumberFromUser()
    {
        string v_Number;
        bool v_NumberIsValid = false;

        Console.WriteLine("Please enter 6 digits long number:");
        v_Number = Console.ReadLine();


        while (!v_NumberIsValid)
        {
            if (v_Number.Length == 6)
            {
                v_NumberIsValid = Ex01_04.Program.IsStrValidNumber(v_Number);
            }
            if (!v_NumberIsValid)
            {
                Console.WriteLine(@"Invalid input!
Please enter 6 digits long number:");
                v_Number = Console.ReadLine();
            }
        }
        int.TryParse(v_Number, out int v_NumberAsInt);

        return v_NumberAsInt;
    }
    private static void howManyDigitsBiggerThanUnits(int i_Number)
    {
        int v_UnitsDigit = i_Number % 10;
        int v_Counter = 0;

        for(int i = 0; i < 5; ++i)
        {
            i_Number = i_Number / 10;

            if(i_Number % 10 > v_UnitsDigit)
            {
                v_Counter++;
            }
        }

        string v_NumOfDigitsBiggerThanUnits = string.Format("The number of digits that are bigger than the uints digit is: {0}", v_Counter);
        Console.WriteLine(v_NumOfDigitsBiggerThanUnits);
    }
    private static void findMinDigit(int i_Number)
    {
        int v_CurrMinDig = i_Number % 10;

        for (int i = 0; i < 6; ++i)
        {
            i_Number = i_Number / 10;

            if (i_Number % 10 < v_CurrMinDig)
            {
                v_CurrMinDig = i_Number % 10;
            }
        }

        string v_MinimumDigitInTheNum = string.Format("The minimum digit in the number is: {0}", v_CurrMinDig);
        Console.WriteLine(v_MinimumDigitInTheNum);
    }
    private static void howManyDigitsDividedByThree(int i_Number)
    {
        int v_CurrentDigitToCheck;
        int v_Counter = 0;

        for (int i = 0; i < 6; ++i)
        {
            v_CurrentDigitToCheck = i_Number % 10;
            i_Number = i_Number / 10;

            if (v_CurrentDigitToCheck % 3 == 0)
            {
                v_Counter++;
            }
        }

        string v_NumOfDigitsBiggerThanUnits = string.Format("The number of digits that are divided by 3 is: {0}", v_Counter);
        Console.WriteLine(v_NumOfDigitsBiggerThanUnits);
    }
    private static void calcDigitsAvarege(int i_Number)
    {
        int v_CurrentDigitToSum;
        int v_DigitsSum = 0;

        for (int i = 0; i < 6; ++i)
        {
            v_CurrentDigitToSum = i_Number % 10;
            i_Number = i_Number / 10;

            v_DigitsSum += v_CurrentDigitToSum;
        }

        string v_DigitsAvarege = string.Format("The avarege of the number's digits is: {0}", v_DigitsSum / 6.0);
        Console.WriteLine(v_DigitsAvarege);
    }
}

