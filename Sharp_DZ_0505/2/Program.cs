using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            string str = Console.ReadLine();
            if (str.Length != 6)
                return;
            try
            {
                int num = int.Parse(str);
                int firstNum = 0, secondNum = Sum3(num % 1000);
                num /= 1000;
                firstNum = Sum3(num);
                if (firstNum == secondNum)
                    Console.WriteLine("Yes");
                else Console.WriteLine("No");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
                return;
            }
        }

        static int Sum3(int tmp)
        {
            int num = 0;
            while (tmp != 0)
            {
                num += tmp % 10;
                tmp /= 10;
            }
            return num;
        }
    }
}
