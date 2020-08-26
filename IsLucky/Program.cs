using System;
using System.Threading;

namespace IsLucky
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter ticket number: ");
            int ticket = int.Parse(Console.ReadLine());
            if (isLucky(ticket))
            {
                Console.WriteLine("It's a lucky ticket!");
            }
            else
            {
                Console.WriteLine("Try another ticket!");
            }
            Console.ReadLine();

            static bool isLucky(int n)
            {
                int firstHalf = 0;
                int secondHalf = 0;
                int length = 0;
                int count = 0;
                int ch;
                int temp = n;
                while (temp > 0)
                {
                    temp = temp / 10;
                    length++;
                }
                while (n > 0)
                {
                    ch = n % 10;
                    n = n / 10;
                    if (count < length / 2)
                    {
                        secondHalf += ch;
                    }
                    else
                    {
                        firstHalf += ch;
                    }
                    count++;
                }
                if (firstHalf == secondHalf)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
