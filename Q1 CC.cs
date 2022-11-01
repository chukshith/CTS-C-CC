using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CC
{
    public static int[,] GetArray(int n)
    {
        int[,] Array2 = new int[n, n];
        for (int a = 0; a < n; a++)
        {
            for (int b = 0; b < n; b++)
            {
                if (a == b)
                {
                    Array2[a, b] = 0;
                }
                if (a < b)
                {
                    Array2[a, b] = 1;
                }
                if (a > b)
                {
                    Array2[a, b] = -1;
                }

            }
        }
        return Array2;
    }
    public static void Main(string[] Args)
    {
        int n;
        Console.WriteLine("Enter the Number:");
        n = Convert.ToInt32(Console.ReadLine());
        int[,] Array = new int[n, n];
        Array = GetArray(n);
        for (int a = 0; a < n; a++)
        {
            Console.WriteLine("\n");
            for (int b = 0; b < n; b++)
            {
                Console.Write("{0}\t", Array[a, b]);

            }
            Console.WriteLine("\n\n");
        }
    }
}
