using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tank;

namespace WordOfTanks
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            tank[] VIN = new tank[5];
            tank[] T34 = new tank[5];

            for (int i = 0; i < T34.Length; i++)
            {
                T34[i] = new tank(rnd.Next(0, 101), rnd.Next(0, 101), rnd.Next(0, 101), "T34");
            }
            tank[] pantera = new tank[5];
            for (int i = 0; i < T34.Length; i++)
            {
                pantera[i] = new tank(rnd.Next(0, 101), rnd.Next(0, 101), rnd.Next(0, 101), "Pantera");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("{0} бой\n~~~~~", i+1);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.Black;
                T34[i].Print();
                pantera[i].Print(); 
                VIN[i] = T34[i] * pantera[i];
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("В {0} схватке победил танк {1}            ",i+1, VIN[i].GetNameTank());
                Console.WriteLine("******************************** ");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
    }
}
