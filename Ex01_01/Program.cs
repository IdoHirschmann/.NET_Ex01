namespace Ex01_01;

using System;

// $G$ THE-001 (-10) The manifest is the part in the assembly that describe it.
// $G$ SFN-999 (-5) The program does not print correctly palindromes, it prints that 1,2,..,9 --> is not palindrome
// $G$ DSN-002 (-10) The program "Hourglass Beginners" does not include only one call to "WriteLine"/"Write" method. 
// $G$ DSN-003 (-5) The code should be divided to methods.
// $G$ DSN-006 (-5) The Main method is short and readable
// $G$ CSS-027 (-2) Unnecessary blank lines.
// $G$ CSS-999 (-2) Missing blank lines.

class Program
{

    public static void Main()
    {
        string v_BinaryNumStrOne, v_BinaryNumStrTwo, v_BinaryNumStrThree;

        Console.WriteLine("Please enter three binary numbers, 8 digits long each:");
        Console.WriteLine("Binary number #1:");
        v_BinaryNumStrOne = getBinaryNumFromUser();
        Console.WriteLine("Binary number #2:");
        v_BinaryNumStrTwo = getBinaryNumFromUser();
        Console.WriteLine("Binary number #3:");
        v_BinaryNumStrThree = getBinaryNumFromUser();
        int v_DecimalNum1 = convertBinaryStringToInt(v_BinaryNumStrOne);
        int v_DecimalNum2 = convertBinaryStringToInt(v_BinaryNumStrTwo);
        int v_DecimalNum3 = convertBinaryStringToInt(v_BinaryNumStrThree);
        printNumbersInDecreaseOrder(v_DecimalNum1, v_DecimalNum2, v_DecimalNum3);
        AvaregeNumOfZerosAndOnes(v_BinaryNumStrOne, v_BinaryNumStrTwo, v_BinaryNumStrThree);
        howManyNumDividedByFour(v_DecimalNum1, v_DecimalNum2, v_DecimalNum3);
        howManyNumHaveDecreseDigitsOrder(v_DecimalNum1, v_DecimalNum2, v_DecimalNum3);
        howManyNumbersArePalindrom(v_DecimalNum1, v_DecimalNum2, v_DecimalNum3);





        Console.ReadLine();
    }


    private static String getBinaryNumFromUser()
    {
        string v_BinaryNumString = Console.ReadLine();

        binaryNumInputValidCheck(ref v_BinaryNumString);
        return v_BinaryNumString;
    }

    private static void binaryNumInputValidCheck(ref string io_BinaryNumStr)
    {
        while (io_BinaryNumStr.Length != 8 || !isBinaryNumValid(io_BinaryNumStr))//long validty
        {
            Console.WriteLine("Invalid input! Please enter 8 digits long binary number:");
            io_BinaryNumStr = Console.ReadLine();
        }

    }

    private static bool isBinaryNumValid(string i_BinaryNumStr)
    {
        for (int i = 0; i < i_BinaryNumStr.Length; ++i)
        {
            if (i_BinaryNumStr[i] != '0' && i_BinaryNumStr[i] != '1')
            {
                return false;
            }
        }

        return true;
    }

    private static int convertBinaryStringToInt(string i_BinaryNumStr)
    {
        int v_DecimalNumber = 0;

        for (int i = 0; i < i_BinaryNumStr.Length; ++i)
        {
            if (i_BinaryNumStr[i_BinaryNumStr.Length - 1 - i] == '1')
            {
                v_DecimalNumber += (int)Math.Pow(2, i);
            }
        }

        return v_DecimalNumber;
    }

    private static void printNumbersInDecreaseOrder(int i_Number1, int i_Number2, int i_Number3)
    {
        int v_MaxNum = i_Number3, v_MidNum = i_Number2, v_MinNum = i_Number1;

        if (i_Number1 >= i_Number2 && i_Number1 >= i_Number3)
        {
            v_MaxNum = i_Number1;

            if (i_Number2 > i_Number3)
            {
                v_MidNum = i_Number2;
                v_MinNum = i_Number3;
            }
            else
            {
                v_MidNum = i_Number3;
                v_MinNum = i_Number2;
            }
        }
        else if (i_Number2 >= i_Number1 && i_Number2 >= i_Number3)
        {
            v_MaxNum = i_Number2;

            if (i_Number1 > i_Number3)
            {
                v_MidNum = i_Number1;
                v_MinNum = i_Number3;
            }
            else
            {
                v_MidNum = i_Number3;
                v_MinNum = i_Number1;

            }
        }
        else if (i_Number3 >= i_Number1 && i_Number3 >= i_Number2)
        {
            v_MaxNum = i_Number3;

            if (i_Number1 > i_Number2)
            {
                v_MidNum = i_Number1;
                v_MinNum = i_Number2;
            }
            else
            {
                v_MidNum = i_Number2;
                v_MinNum = i_Number1;
            }
        }

        string v_DecreseOrder = string.Format("The numbers in decrease order: {0} , {1} , {2}", v_MaxNum.ToString(), v_MidNum.ToString(), v_MinNum.ToString());
        Console.WriteLine(v_DecreseOrder);
    }

    private static void AvaregeNumOfZerosAndOnes(string i_Number1, string i_Number2, string i_Number3)
    {
        int v_NumOfZeros = 0, v_NumOfOnes = 0;

        v_NumOfZeros += countZerosInBinaryNum(i_Number1) + countZerosInBinaryNum(i_Number2) + countZerosInBinaryNum(i_Number3);
        v_NumOfOnes = 24 - v_NumOfZeros; //in tottal we have 24 bits

        string v_AvaregeNumOfZerosAndOnes = string.Format(@"The avarege number of zeros is: {0}.
The avarege number of ones is: {1}", (v_NumOfZeros / 3.0).ToString(), (v_NumOfOnes / 3.0).ToString());
        Console.WriteLine(v_AvaregeNumOfZerosAndOnes);
    }

    private static int countZerosInBinaryNum(string i_BinaryNum)
    {
        int v_ZeroCounter = 0;

        for (int i = 0; i < 8; ++i)
        {
            if (i_BinaryNum[i] == '0')
            {
                v_ZeroCounter++;
            }
        }

        return v_ZeroCounter;
    }

    private static void howManyNumDividedByFour(int i_Number1, int i_Number2, int i_Number3)
    {
        int v_NumOfNumDividedByFour = 0;

        if (i_Number1 % 4 == 0)
        {
            v_NumOfNumDividedByFour++;
        }

        if (i_Number2 % 4 == 0)
        {
            v_NumOfNumDividedByFour++;
        }

        if (i_Number3 % 4 == 0)
        {
            v_NumOfNumDividedByFour++;
        }

        string v_NumOfNumbersDividedByFourStr = string.Format("The number of numbers divided by 4 is: {0}", v_NumOfNumDividedByFour);
        Console.WriteLine(v_NumOfNumbersDividedByFourStr);
    }

    private static void howManyNumHaveDecreseDigitsOrder(int i_Number1, int i_Number2, int i_Number3)
    {
        int v_NumOfNumbersWithDecreseDegitOrder = 0;

        v_NumOfNumbersWithDecreseDegitOrder += isNumHaveDecreseDigitsOrder(i_Number1);
        v_NumOfNumbersWithDecreseDegitOrder += isNumHaveDecreseDigitsOrder(i_Number2);
        v_NumOfNumbersWithDecreseDegitOrder += isNumHaveDecreseDigitsOrder(i_Number3);
        string v_NumOfNumbersWithDecreseDegitOrderStr = string.Format("The number of numbers that have decrese digits order: {0}", v_NumOfNumbersWithDecreseDegitOrder);
        Console.WriteLine(v_NumOfNumbersWithDecreseDegitOrderStr);
    }

    private static int isNumHaveDecreseDigitsOrder(int i_Number)
    {
        if(i_Number >99)
        {
            return ((i_Number % 10 < (i_Number / 10) % 10) && (((i_Number / 10) % 10) < ((i_Number / 100) % 10))) ? 1 : 0;
        }
        else if(i_Number > 9)
        {
            return ((i_Number % 10 < (i_Number / 10) % 10)) ? 1 : 0;
        }
        else
        {
            return 1; //one digit is a decrese order.
        }
    }

    private static void howManyNumbersArePalindrom(int i_Number1, int i_Number2, int i_Number3)
    {
        int v_NumOfPalindromNumbers = 0;

        v_NumOfPalindromNumbers += isNumberPalindrom(i_Number1);
        v_NumOfPalindromNumbers += isNumberPalindrom(i_Number2);
        v_NumOfPalindromNumbers += isNumberPalindrom(i_Number3);
        string v_NumOfPalindromNumbersStr = string.Format("The number of palindrom numbers is: {0}", v_NumOfPalindromNumbers);
        Console.WriteLine(v_NumOfPalindromNumbersStr);
    }

    private static int isNumberPalindrom(int i_Number)
    {
        return (i_Number % 10 == (i_Number / 100) % 10 ? 1 : 0);
    }
}