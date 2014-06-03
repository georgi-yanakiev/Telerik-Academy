using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallingWordsGame
{
    // Point in 2D coordinates
    public class Coordinates
    {
        public int posX { get; private set; }
        public int posY { get; private set; }

        public Coordinates(int X, int Y)
        {
            posX = X;
            posY = Y;
        }

        public static Coordinates operator+(Coordinates a, Coordinates b)
        {
            return new Coordinates(a.posX + b.posX, a.posY + b.posY);
        }

        public static Coordinates operator-(Coordinates a, Coordinates b)
        {
            return new Coordinates(a.posX - b.posX, a.posY - b.posY);
        }

    }
}
