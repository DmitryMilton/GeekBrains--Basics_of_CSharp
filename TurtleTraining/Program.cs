using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtleTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            Turtle.Speed = 19;
            int i = 0;
            while (i < 6)
            {
                Turtle.Move(102);
                Turtle.Turn(60);
                i++;
            }

            Turtle.Move(55);

            Turtle.Speed = 15;
            i = 0;
            while(i < 21)
            {
                if (i % 4 < 2) Turtle.TurnRight();
                else Turtle.TurnLeft();
                Turtle.Move(16);
                i++;
            }

            Turtle.Hide();
        }
    }
}
