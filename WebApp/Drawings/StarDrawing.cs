using System;
using System.Security.Cryptography.X509Certificates;
using WebApp.Model;

namespace WebApp.Drawings
{
	public class StarDrawing
	{
        public void DrawOneStar(ITurtle t)
        {
            double startSize = 200; 
            double startcx = 500; 
            double startcy = 300;
            double lines = 72;
            double size = startSize;
            double innerRadius = 10;
            double turnAngle = 5;
            (double cx, double cy) = Calculate_cx_cy(startcx, startcy, turnAngle, 0, innerRadius);
            // (center for stjernen er (cx,cy)

            t.Up();
            t.MoveTo(cx, cy);
            t.TurnTo(0);
            t.Down();
            t.Width = 2;
           
            for (int i = 0; i < lines; i++)
            {
                // Assign colours based on time tables
                if (i % 7 == 0)
                {
                    t.Color = "pink";
                }
                else if (i % 3 == 0)
                {
                    t.Color = "red";
                }
                else if (i % 2 == 0)
                {
                    t.Color = "yellow";
                } else 
                {
                    t.Color = "blue";
                }
                t.Move(size);
                //size -= startSize / lines;
                t.Up();
                if (i % 2 == 0)
                {
                    (cx, cy) = Calculate_cx_cy(startcx, startcy, turnAngle, i, innerRadius);
                } else
                {
                    (cx, cy) = Calculate_cx_cy(startcx, startcy, turnAngle, i, innerRadius+30);
                }

                t.MoveTo(cx, cy);
                t.Turn(turnAngle);
                t.Down();
            }

            static (double, double) Calculate_cx_cy (double startcx, double startcy, double turnAngle, int i, double innerRadius) 
            {
                double currentAngle = turnAngle * i;
                double radians = Math.PI / 180 * currentAngle;
                double cx = innerRadius * Math.Cos(radians) + startcx;
                double cy = innerRadius * Math.Sin(radians) + startcy;
                return (cx, cy);
            }
        }


        
        /// <summary>
        /// Draw [n] stars of random size and location using
        /// the turtle [t]
        /// </summary>
        /// <param name="t">The turtle to draw with</param>
        /// <param name="n">The number of stars</param>
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

