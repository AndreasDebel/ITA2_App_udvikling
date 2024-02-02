﻿using System;
namespace WebApp.Model
{
    public class Turtle : ITurtle
    {
        private double x = 0;
        private double y = 0;
        private double degree = 0;

        private bool isDown = true;

        public static List<Line> mLines = new();

        public Turtle()
        {
           
            Color = "black";
        }

        public void Down() { isDown = true; }
        public void Up() { isDown = false; }

        public void Move(double distance)
        {
            var radian = degree * 2 * Math.PI / 360;
            var newx = x + Math.Cos(radian) * distance;
            var newy = y + Math.Sin(radian) * distance;


            if (isDown)
                mLines.Add(new Line { X1 = x, Y1 = y, X2 = newx, Y2 = newy, Color= this.Color });
            x = newx;
            y = newy;
        }

        public void Turn(double d)
        {
            this.degree += d;
        }

        public void Reset()
        {
            x = 0; y = 0; degree = 0;
        }

        public void MoveTo(double nx, double ny)
        {
            var newx = nx;
            var newy = ny;

            if (isDown)
                mLines.Add(new Line { X1 = x, Y1 = y, X2 = newx, Y2 = newy, Color = this.Color });
            x = newx;
            y = newy;
        }

        public void TurnTo(double d)
        {
            degree = d;
        }

        public string Color { get; set; }


    }
}

