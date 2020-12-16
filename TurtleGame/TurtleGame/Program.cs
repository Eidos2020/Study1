using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphicsWindow.KeyDown += GraphicsWindow_KeyDown;
            Turtle.PenUp();
            GraphicsWindow.BrushColor = "Red";
            var eat = Shapes.AddRectangle(10, 10);
            int y = 200;
            int x = 200;
            Shapes.Move(eat, x, y);
            Random rand = new Random();
            while (true)
            {
                Turtle.Move(10);
                if ((Turtle.X >= x - 10 && Turtle.X <= x + 10) && (Turtle.Y >= y - 10 && Turtle.Y <= y + 10))
                {
                   y = rand.Next(0, GraphicsWindow.Height);
                   x = rand.Next(0, GraphicsWindow.Width);
                   Shapes.Move(eat, x, y);
                    Turtle.Speed++;
                 }
                if (Turtle.X > GraphicsWindow.Width)
                {
                    Turtle.X = 0;
                }
                if (Turtle.Y > GraphicsWindow.Height)
                {
                    Turtle.Y = 0;
                }
                if (Turtle.X < 0)
                {
                    Turtle.X = GraphicsWindow.Width;
                }
                if (Turtle.Y < 0)
                {
                    Turtle.Y = GraphicsWindow.Height;
                }


            }
                

        }
        private static void GraphicsWindow_KeyDown() 
        {
            if (GraphicsWindow.LastKey == "Up") 
            {
                Turtle.Angle = 0;
            }
            else if (GraphicsWindow.LastKey == "Down")
            {
                Turtle.Angle = 180;
            }
            else if (GraphicsWindow.LastKey == "Right")
            {
                Turtle.Angle = 90;
            }
            else if (GraphicsWindow.LastKey == "Left")
            {
                Turtle.Angle = 270;
            }

        }
            
    
    }
}
    