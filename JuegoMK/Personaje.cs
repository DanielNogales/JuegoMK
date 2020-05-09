using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace JuegoMK
{
    public class Personaje
    {
        public string Nombre {get; set;}
        public int Salud { get; set; }
        public ConsoleColor Color { get; set; }

        public void atacar(Personaje oponente, int danio)
        {
            oponente.Salud = oponente.Salud - danio;
        }
    }
}
