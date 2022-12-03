// See https://aka.ms/new-console-template for more information
using System;
namespace ConsoleApp1
{
    class Program
    {   public static string Reverse( string s )   /*функция, которая разворачивает
     строку наоборот*/
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number\n");
            int n = Convert.ToInt32(Console.ReadLine());
            string s = "";
            while (n > 0)
            {
                int lastdigit = n % 2;       //находим цифры двоичного числа
                n /= 2;
                s += Convert.ToString(lastdigit);     //записываем их в строку
            }

            Console.WriteLine(Reverse(s));
            Console.ReadKey();

        }
    }
}


