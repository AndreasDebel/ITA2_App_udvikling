using System;
using System.Security.Cryptography.X509Certificates;
using WebApp.Model;

namespace WebApp.Drawings
{
	public class CircleDrawing
	{
        public void DrawOneCircle(ITurtle t, double radius)
        {
            //Variable values
            double startcx = 300;
            double startcy = 300;
            int steps = 360;
            double angleStep = 360.0 / steps;
            double lineLength = (2 * Math.PI * radius) / steps;


            //Drawings the circle
            t.Up();
            t.MoveTo(startcx + radius, startcy);
            t.Turn(180);
            t.StrokeType = "normal";
            t.Down();

            for (int i = 0; i < steps; i++)
            {
                t.Move(lineLength);
                t.Turn(angleStep);
            }


                


        }


        
        public void DrawManyStars(ITurtle t, int n)
        {
            Random r = new Random();
            t.Width = 1;

            for (int i = 0; i < n; i++)
            {
                int size = 50 + r.Next(100);
                int cx = size + r.Next(1000 - 2*size);
                int cy = size + r.Next(600 - 2*size);
                
                DrawOneStar(t, size, cx, cy);
            }
        }
        
        private void DrawOneStar(ITurtle t, double size, double cx, double cy)
        {
            t.Up();
            t.MoveTo(cx, cy);
            t.TurnTo(0);
            t.Down();
            t.Width = 1;
           
            for (int i = 0; i < 36; i++)
            {           
                t.Move(size);
                t.Up();
                t.MoveTo(cx, cy);
                t.Turn(10);
                t.Down();
            }
        }
    }
}

