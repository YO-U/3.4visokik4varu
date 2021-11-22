using System;

namespace _3._4visokik4varu
{
    class Program
    {
        static void Main(string[] args)
        {
              try
            {
                double n = 9;
                for (double x = 1; x <= 2; x += 0.1) 
                {          
                        double S = 0;
                   
                        for (double k = 1; k <= n; k++)
                        {
                            long F = 1;
                            for (int j = 1; j < 3*k; j++) F *= j;
                            S += Math.Pow(-1, (3*k)) * Math.Pow(x, (3*k)) / F ;
                        }
                    Console.WriteLine("|{0,13:F2}|{1,14:F2}|", x, S);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
