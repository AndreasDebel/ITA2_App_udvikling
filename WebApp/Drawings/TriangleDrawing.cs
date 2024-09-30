using System;
using WebApp.Model;

namespace WebApp.Drawings
{
	public class TriangleDrawing
	{
		public TriangleDrawing()
		{
		}

        public void DrawTriangle(ITurtle t, double width, int level)
        {
            t.StrokeType = "dashed";
            if (level == 0)
                t.Move(width);
            else
            {
                var nw = width / 3;
                DrawTriangle(t, nw, level - 1);
                t.Turn(-60);
                DrawTriangle(t, nw, level - 1);
                t.Turn(120);
                DrawTriangle(t, nw, level - 1);
                t.Turn(-60);
                DrawTriangle(t, nw, level - 1);
            }
        }
    }
}

