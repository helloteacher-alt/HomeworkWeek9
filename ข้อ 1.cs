using System;

namespace _111111
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());
            int vvv = 1, i, j;
            if (row < 0) { Console.WriteLine("Invalid Pascal’s triangle row number."); }
            for (i = 0; i <= row; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0)
                        vvv = 1;
                    else
                        vvv = vvv * (i - j + 1) / j;
                    Console.Write(vvv + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
