using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPlayer = int.Parse(Console.ReadLine());
            int secondPlayer = int.Parse(Console.ReadLine());
            int battles = int.Parse(Console.ReadLine());
            int count = 0;

            for(int i=1; i<=firstPlayer; i++)
            {
                for(int j=1; j<=secondPlayer; j++)
                {
                    count++;
                    if (count<=battles)
                    {
                        Console.Write("({0} <-> {1}) ", i,j);
                    }
                    else
                    {
                        break;
                    }
                    
                }
            }
        
        }
    }
}
