using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            char ch;
            do
            {
                ch = Console.ReadKey().KeyChar;
                if (ch == ' ')
                    count++;
            } while (ch != '.');

            Console.WriteLine("Count of spaces: {0}", count);
            Console.ReadLine();
        }
    }
}
