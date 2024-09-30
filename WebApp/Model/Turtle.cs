using System;
namespace WebApp.Model
{
    public class Turtle : ITurtle
    {
        private double x = 0;
        private double y = 0;
        private double degree = 0;

        private bool isDown = true;

        public List<Line> mLines = new();

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
            var newhalfx = x + (Math.Cos(radian) * distance)/2;
            var newhalfy = y + (Math.Sin(radian) * distance)/2;

            if (newx >= 1000)
                newx = 999;
            if (newx < 0) newx = 0;

            if (newy >= 600)
                newy = 599;
            if (newy < 0) newy = 0;

            if (isDown)
                if (StrokeType == "normal")
                {
                    mLines.Add(new Line { X1 = x, Y1 = y, X2 = newx, Y2 = newy, Color = this.Color, Width = this.Width });
                    x = newx;
                    y = newy;
                } else if (StrokeType == "dashed")
                {
                    //Find the distance between the new and the old x coordinates
                    double x_distance = 0;
                    if(x > newx)
                    {
                        x_distance = x - newx;
                    } else if (x <= newx)
                    {
                        x_distance = newx - x;
                    }

                    //Find the distance between the new and the old y coordinates
                    double y_distance = 0;
                    if(y > newy)
                    {
                        y_distance = y - newy;
                    } else if (y <= newy) 
                    {
                        y_distance = newy - y;
                    } 

                    //Caculate hypotenuse - the distance between the new and the old points
                    double hypothenuse = Math.Sqrt(Math.Pow(y_distance, 2) + Math.Pow(x_distance, 2));

                    int dashLength = 10;
                    int numOfDashes = Convert.ToInt32(hypothenuse) / dashLength;

                    double x_difference = newx - x;
                    double y_difference = newy - y;
                    for (int i = 0; i < numOfDashes; i++)
                    {
                        mLines.Add(new Line { X1 = x, Y1 = y, X2 = x + (x_difference/numOfDashes)/2, Y2 = y + (y_difference/numOfDashes)/2, Color = this.Color, Width = this.Width });
                        x = x + (x_difference/numOfDashes);
                        y = y + (y_difference/numOfDashes);
                    }
                }
 

        }



        public void Turn(double d)
        {
            this.degree += d;
        }

        public void Reset()
        {
            x = 0; y = 0; degree = 0; Width = 1;
        }

        public void MoveTo(double nx, double ny)
        {
            var newx = nx;
            var newy = ny;

            if (isDown)
                mLines.Add(new Line { X1 = x,
                                      Y1 = y,
                                      X2 = newx,
                                      Y2 = newy,
                                      Color = this.Color,
                                      Width = this.Width });
            x = newx;
            y = newy;
        }

        public void TurnTo(double d)
        {
            degree = d;
        }

        public string Color { get; set; } = "black";
        public double Width { get; set; } = 1;

        public string StrokeType { get; set; } = "normal";
    }
}

