using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            String str = Console.ReadLine();

            char[] chs = str.ToCharArray();

            for (int i = 0; i < chs.Length; i++)
            {
                if (chs[i] == Char.ToLower(chs[i]))
                {
                    chs[i] = Char.ToUpper(chs[i]);
                    Console.Write(chs[i]);
                    continue;
                }
                if (chs[i] == Char.ToUpper(chs[i]))
                    chs[i] = Char.ToLower(chs[i]);
                Console.Write(chs[i]);
            }
            Console.WriteLine();
            Console.ReadLine();
            
        }
    }
}
