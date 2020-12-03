using System;
using System.Diagnostics;

namespace Lab5OS
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int[,] a = CreateMatrix();
            
            ShowMatrix(a);

            Console.WriteLine();

            for (int i = 99; i > 0; i--)
            {
                
                for (int j = 99; j > 0; j--)
                {
                    a[i, j] = a[i - 1, j - 1];
                }
            }
            ShowMatrix(a);

            Console.WriteLine();



            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    a[i, j]--;
                }
            }
            ShowMatrix(a);

            Console.WriteLine();

            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }

        static int[,] CreateMatrix()
        {
            int[,] a = new int[100, 100];
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {

                for (int j = 0; j < 100; j++)
                {
                    a[i, j] = random.Next(10);
                }
            }
            return a;
        }

        static void ShowMatrix(int[,] matrix)
        {
            for (int i = 0; i < 100; i++)
            {

                for (int j = 0; j < 100; j++)
                {
                    Console.Write("{0,4}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
