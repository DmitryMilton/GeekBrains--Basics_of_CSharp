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
        static void WriteT(int size)
        {
            Turtle.Angle = 0;
            Turtle.Move( size );
            Turtle.Angle = 270;
            Turtle.Move( size / 3 );
            Turtle.Angle = 90;
            Turtle.Move( size * 2 / 3 );
        }

        static void WriteO(int size)
        {
            Turtle.Angle = 0;
            Turtle.Move( size );
            Turtle.Angle = 90;
            Turtle.Move( size / 2 );
            Turtle.Angle = 180;
            Turtle.Move( size );
            Turtle.Angle = 270;
            Turtle.Move( size / 2 );
        }

        static void WriteR(int size)
        {
            Turtle.Angle = 0;
            Turtle.Move( size );
            Turtle.Angle = 90;
            Turtle.Move( size / 2 );
            Turtle.Angle = 180;
            Turtle.Move( size / 2 );
            Turtle.Angle = 270;
            Turtle.Move( size / 2 );
        }

        static void Main(string[] args)
        {
            Turtle.Speed = 10;
            
            for ( int i = 0; i < 6; i++ )
            {
                Turtle.Move(102);
                Turtle.Turn(60);
            }

            Turtle.Move(55);

            Turtle.Speed = 10;
            for ( int i = 0; i < 21; i++ )
            {
                if ( i % 4 < 2 ) Turtle.TurnRight();
                else Turtle.TurnLeft();
                Turtle.Move(16);
            }

            int ordY = 220;
            int ordX = 150;
            int size = 60;

            Turtle.X = ordX;
            Turtle.Y = ordY;

            WriteT( size * 2 );

            Turtle.X = ordX = ordX + 5 + size / 2;
            Turtle.Y = ordY;

            WriteO( size );

            Turtle.X = ordX = ordX + 5 + size / 2;
            Turtle.Y = ordY;

            WriteR( size );

            Turtle.X = ordX + size - 5;
            Turtle.Y = ordY;

            WriteT( size );

            Turtle.Hide();
        }
    }
}
