﻿using System;
using WebApp.Model;

namespace WebApp.Drawings
{
	public class StarDrawing
	{
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
                
                // to-do: overfør size, cx og cy som parametre til DrawOneStar
                DrawOneStar(t);
            }

        }

        public void DrawOneStar(ITurtle t)
        {

            double size = 75; 
            double cx = 500; 
            double cy = 300;
            // (center for stjernen er (cx,cy)
            
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

