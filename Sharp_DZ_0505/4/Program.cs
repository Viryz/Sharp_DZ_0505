using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            try
            {
                int num = int.Parse(Console.ReadLine());
                int newNum = 0;
                do
                {
                    newNum += num % 10;
                    newNum *= 10;
                    num /= 10;
                } while (num != 0);
                newNum /= 10;
                Console.WriteLine(newNum);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
                return;
            }
        }
    }
}
