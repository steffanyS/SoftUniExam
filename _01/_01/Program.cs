using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            double skumriaPrice = double.Parse(Console.ReadLine());
            double cacaPrice = double.Parse(Console.ReadLine());
            double kgPalamud = double.Parse(Console.ReadLine());
            double kgSafrid = double.Parse(Console.ReadLine());
            int kgMidi = int.Parse(Console.ReadLine());

            double palamudPrice = skumriaPrice + skumriaPrice * 0.6;
            double safridPrice = cacaPrice + cacaPrice * 0.8;

            double midiPrice = 7.5;

            double total = 0;

            total = kgPalamud * palamudPrice + kgSafrid * safridPrice + (double)((double)kgMidi * midiPrice);

            // Console.WriteLine(Math.Round(total,2));
           // Console.WriteLine("{0:n2}", total);
            Console.WriteLine("{0:f2}", total);
        }
    }
}
