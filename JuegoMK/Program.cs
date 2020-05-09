using System;
using System.Drawing;
using System.Security.Cryptography;

namespace JuegoMK
{
    class Program
    {
        static void Main(string[] args)
        {
            Personaje p1 = new Personaje();
            p1.Nombre = "Scorpion";
            p1.Salud = 100;
            p1.Color = ConsoleColor.Yellow;

            Personaje p2 = new Personaje();
            p2.Nombre = "SubZero";
            p2.Salud = 100;
            p2.Color = ConsoleColor.Blue;

            bool turnoP1 = true;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Fight!!!");


            while (p1.Salud > 0 && p2.Salud > 0)
            {

                int max = 10;
                int min = 2;

                Random rnd = new Random();
                int danio = rnd.Next(min, max);

                Personaje atacante;
                Personaje oponente;

                if (turnoP1)
                {
                    atacante = p1;
                    oponente = p2;
                } 
                else
                {
                    atacante = p2;
                    oponente = p1;
                }

                Console.ForegroundColor = atacante.Color;
                Console.WriteLine(atacante.Nombre + " ataca a " + oponente.Nombre);
                
                atacante.atacar(oponente, danio);
                Console.WriteLine("A " + oponente.Nombre + " le queda " + oponente.Salud);

                turnoP1 = !turnoP1;
            }

            Console.WriteLine("...");

            Console.ForegroundColor = ConsoleColor.Magenta;
            if (p1.Salud > 0)
                Console.WriteLine($"Gano {p1.Nombre}");
            else
                Console.WriteLine($"Gano {p2.Nombre}");

            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
