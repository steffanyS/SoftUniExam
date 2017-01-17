using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            int adults = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            string transport = Console.ReadLine();

            double total = days*82.99;

            if(transport=="train")
            {
                if(students+adults>=50)
                {
                    total += (adults * 24.99 + students * 14.99)*2*0.5;
                }
                else
                {
                    total += (adults * 24.99 + students * 14.99)*2;
                }
            }
            if(transport=="bus")
            {
                total += (adults * 32.50 + students * 28.50)*2;
            }
            if(transport=="boat")
            {
                total +=( adults * 42.99 + students * 39.99)*2;
            }
            if(transport=="airplane")
            {
                total += (adults * 70 + students * 50)*2;
            }

            total += total * 0.1;

            Console.WriteLine("{0:F2}", total);
        }
    }
}
