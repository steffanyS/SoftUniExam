using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int totalFood = int.Parse(Console.ReadLine());
            double dogFood = double.Parse(Console.ReadLine());
            double catFood = double.Parse(Console.ReadLine());
            double turtleFood = double.Parse(Console.ReadLine());

            double eatenFood = days * (dogFood + catFood + turtleFood / 1000);

            if (totalFood >= eatenFood)
            {
                Console.WriteLine("{0} kilos of food left.",Math.Floor(totalFood-eatenFood));            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(eatenFood-totalFood));
            }
        }
    }
}
