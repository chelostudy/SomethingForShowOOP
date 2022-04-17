using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomephingForShowOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter Mass (kilo) or type something to exit");
                if (!int.TryParse(Console.ReadLine(), out int mass))
                {
                    break;
                }

                Console.WriteLine("Please enter Speed (m/sec)");
                int speed = int.Parse(Console.ReadLine());

                Console.WriteLine(SimpleClass.FindEnergy(mass, speed));
            }
        }
    }
    public class SimpleClass
    {
        public static double FindEnergy(double MassObj, double SpeedObj) 
        {
            return MassObj * (SpeedObj * SpeedObj)/2;
        }
    }
}
