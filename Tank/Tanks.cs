using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank
{
    public class tank
    {
        private string name;
        private int boekomplekt;
        private int lvlBroni;
        private int lvlManevr;
        public tank(int boekomplekt, int lvlBroni, int lvlManevr, string name)
        {

            this.boekomplekt = boekomplekt;
            this.lvlBroni = lvlBroni;
            this.lvlManevr = lvlManevr;
            this.name = name;
        }
        public tank()
        {
            boekomplekt = 0;
            lvlBroni = 0;
            lvlManevr = 0;
            name = "null";
        }
        public string GetNameTank()
        {
            return name;
        }
        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Название танка - " + name+"               ");
            Console.WriteLine("Боекомплект = " + boekomplekt + " Уровень брони = " + lvlBroni + " Уровень маневренности = " + lvlManevr+ " ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
        }

        public static tank operator *(tank T34, tank pantera)
        {
            if (T34.boekomplekt > pantera.boekomplekt && T34.lvlBroni > pantera.lvlBroni)
            {
                return T34;
            }
            if (T34.boekomplekt > pantera.boekomplekt && T34.lvlManevr > pantera.lvlManevr)
            {
                return T34;
            }
            if (T34.lvlBroni > pantera.lvlBroni && T34.lvlManevr > pantera.lvlManevr)
            {
                return T34;
            }
            else           
                return pantera;            
        }
    }
}
