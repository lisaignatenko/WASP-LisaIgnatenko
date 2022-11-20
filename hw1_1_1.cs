// See https://aka.ms/new-console-template for more information

using System;
namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            for (int i=1;i<7; i++)
            {
                for (int j=i+1;j<8;j++ )
                {
                    for (int k=j+1;k<9;k++ )
                    {
                        int l = k + 1;
                        Console.WriteLine($"{i}{j}{k}{l}");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
