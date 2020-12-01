using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering
{
    class Program
    {
        static void Main(string[] args)
        {

            int nr;
            string str;
            int gissningar = 0;
            Random randomerare = new Random();
            int slumpTal = randomerare.Next(1, 101);

            Console.WriteLine("Gissa på ett tal mellan 1 till 100 : ");
            str = Console.ReadLine();
            nr = int.Parse(str);

            do
            {
                if (nr < slumpTal && nr + 1 == slumpTal)
                {
                    Console.WriteLine("Gissa igen : ");
                    str = Console.ReadLine();
                    nr = int.Parse(str);
                }
                else if (nr < slumpTal) 

                {
                    Console.WriteLine("Du gissade för lågt!");
                    Console.WriteLine("Gissa igen : ");
                    str = Console.ReadLine();
                    nr = int.Parse(str);
                }
                else if (nr > slumpTal)
                {
                    Console.WriteLine("Du gissade för högt");
                    Console.WriteLine("Gissa igen : ");
                    str = Console.ReadLine();
                    nr = int.Parse(str);
                }
                else if (nr > slumpTal && nr - 1 == slumpTal)
                {
                    Console.WriteLine("Gissa igen : ");
                    str = Console.ReadLine();
                    nr = int.Parse(str);
                }
                gissningar++;
            } while (nr != slumpTal);

            if (nr == slumpTal)
            {
                Console.WriteLine("Grattis! Du gissade rätt!");
                Console.WriteLine("Du gissade " + gissningar + " gånger.");
            }

        }
    }
    }

