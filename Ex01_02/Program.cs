namespace Ex01_02;

using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        StringBuilder v_StarsStr = new StringBuilder ("    *    ");

        PrintDimondRec(9, 1, v_StarsStr);

        Console.ReadLine();
    }

    public static void PrintDimondRec(int i_DimondHeight, int i_Level, StringBuilder i_StarsStr)
    {
        if(i_DimondHeight/2 + 1 == i_Level)
        {
            Console.WriteLine(i_StarsStr);
        }
        else
        {
            Console.WriteLine(i_StarsStr);
            i_StarsStr[i_DimondHeight / 2 - i_Level] = '*';
            i_StarsStr[i_DimondHeight / 2 + i_Level] = '*';
            PrintDimondRec(i_DimondHeight, i_Level+1, i_StarsStr);
            i_StarsStr[i_DimondHeight / 2 - i_Level] = ' ';
            i_StarsStr[i_DimondHeight / 2 + i_Level] = ' ';
            Console.WriteLine(i_StarsStr);
        }
    }
}