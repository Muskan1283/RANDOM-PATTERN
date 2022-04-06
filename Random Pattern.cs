using System;

namespace Random_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 5;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j >= 1; j--)
                {
                    Random rd = new Random();
                    int n = rd.Next(65, 90);
                    Console.Write(Convert.ToChar(n) + "");
                }
                Console.WriteLine();
            }

        }
    }
}

