using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] peopleInGroups = new int[n];
            int lekAvtomobil=0;
            int mikrobus = 0;
            int malukavtobus = 0;
            int golqmAvtobus = 0;
            int vlak = 0;
            int total=0;

            for(int i=0; i<n; i++)
            {
                peopleInGroups[i] = int.Parse(Console.ReadLine());
            }

            for(int i=0; i<n; i++)
            {
                if(peopleInGroups[i]<=5)
                {
                    lekAvtomobil += peopleInGroups[i];
                }
                if(peopleInGroups[i]>=6 && peopleInGroups[i]<=12)
                {
                    mikrobus += peopleInGroups[i];
                }
                if(peopleInGroups[i]>=13 && peopleInGroups[i]<=25)
                {
                    malukavtobus += peopleInGroups[i];
                }
                if(peopleInGroups[i]>=26 &&peopleInGroups[i]<=40)
                {
                    golqmAvtobus += peopleInGroups[i];
                }
                if(peopleInGroups[i]>=41)
                {
                    vlak += peopleInGroups[i];
                }

                total += peopleInGroups[i];
            }

            Console.WriteLine("{0:n2}%",(double)lekAvtomobil/(double)total*100);
            Console.WriteLine("{0:n2}%", (double)mikrobus / (double)total * 100);
            Console.WriteLine("{0:n2}%", (double)malukavtobus / (double)total * 100);
            Console.WriteLine("{0:n2}%", (double)golqmAvtobus / (double)total * 100);
            Console.WriteLine("{0:n2}%", (double)vlak / (double)total * 100);
        }
    }
}
