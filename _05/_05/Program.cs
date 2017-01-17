using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i=0; i<n; i++)
            {
                Console.Write(new string('*', i + 1));
                Console.Write("\\");
                Console.Write(new string('-', (2*n+3)-(i+2)*2));
                Console.Write("/");
                Console.Write(new string('*', i + 1));
                Console.WriteLine();
            }

            for(int i=0; i<n/3; i++)
            {
                Console.Write("|");
                Console.Write(new string('*', n / 2+i));
                Console.Write("\\");
                Console.Write(new string('*', n - i*2 ));
                Console.Write("/");
                Console.Write(new string('*', n / 2 + i));
                Console.Write("|");
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('-', i + 1));
                Console.Write("\\");
                Console.Write(new string('*', (2 * n + 3) - (i + 2) * 2));
                Console.Write("/");
                Console.Write(new string('-', i + 1));
                Console.WriteLine();
            }
        }
    }
}
