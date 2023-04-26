namespace Ex01_03;
using System;
using System.Text;

// $G$ SFN-012 (-5) The program does not cope properly with invalid input, what about zero if for 2 you print 3 lines then 0 should print 1 line
class Program
{
    public static void Main()
    {
        int v_DimondHeight = getHeightFromUser();

        printDimondHelper(v_DimondHeight);
        Console.ReadLine();
    }

    private static int getHeightFromUser()
    {
        string v_DimondHeightStr;

        Console.WriteLine("Please enter height:");
        v_DimondHeightStr = Console.ReadLine();
        int.TryParse(v_DimondHeightStr, out int v_DimondHeight);
        while(v_DimondHeight <1)
        {
            Console.WriteLine("Invalid input! please enter positive number:");
            v_DimondHeightStr = Console.ReadLine();
            int.TryParse(v_DimondHeightStr, out v_DimondHeight);
        }

        if (v_DimondHeight % 2 == 0)
        {
            v_DimondHeight++; //taking care of the case of even number  
        }

        return v_DimondHeight;
    }

    private static void printDimondHelper(int i_DimondHeight)
    {
        StringBuilder v_StarsStr = new StringBuilder("",i_DimondHeight);

        for(int i = 0; i < i_DimondHeight / 2; ++i)
        {
            v_StarsStr.Append(" ");
        }

        v_StarsStr.Append("*");

        for (int i = i_DimondHeight / 2 + 1; i < i_DimondHeight; ++i)
        {
            v_StarsStr.Append(" ");
        }

        Ex01_02.Program.PrintDimondRec(i_DimondHeight, 1, v_StarsStr);
    }
}