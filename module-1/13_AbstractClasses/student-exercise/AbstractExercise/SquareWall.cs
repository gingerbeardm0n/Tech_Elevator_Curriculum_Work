using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExercise
{
    class SquareWall : RectangleWall
    {
        public int Sidelength { get; }


        public SquareWall(string name, string color, int sideLength) : base(name, color, sideLength, sideLength)
        {
            Sidelength = sideLength;
        }
        public override string ToString()
        {
            return Name + " (" + Sidelength + "x" + Sidelength + ") square";
        }




    }
}
