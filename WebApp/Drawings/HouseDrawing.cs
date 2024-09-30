using System;
using WebApp.Model;

namespace WebApp.Drawings
{
	public class HouseDrawing
	{
		public HouseDrawing()
		{
		}

		public void DrawHouse(ITurtle t) {
			int width = 250;
			int height = 100;
			t.StrokeType = "dashed";
			t.Up();
			t.MoveTo(50, 250);
			t.Down();
			t.Width = 2;
			t.Move(width); // gulv
			t.Turn(-90);
			t.Move(height); // væg
			t.Turn(-90);
			t.Move(width); // loft
			t.Turn(-90);
			t.Move(height); // væg
			t.Turn(-180);
			t.Up();
			t.Move(height);
			t.Down();
			t.MoveTo(50 + width/2, 250-2*height); // tag
			t.MoveTo(50+width,250-height); // tag
		}
	}
}

