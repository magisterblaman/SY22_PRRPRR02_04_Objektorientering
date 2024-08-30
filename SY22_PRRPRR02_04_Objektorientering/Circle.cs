using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_04_Objektorientering {
	internal class Circle {
		public int radius;
		public double x;
		public double y;
		public string color;
		public string name;

		public Circle(int inputRadius,
			   double inputX,
			   double inputY,
			   string inputColor,
			   string inputName) {

			radius = inputRadius;
			x = inputX;
			y = inputY;
			color = inputColor;
			name = inputName;

		}

		public void DrawSelf() {
			Console.WriteLine("Hej! Jag är en " + color 
				+ " cirkel och mitt namn är " + name);
			Console.WriteLine("radie: " + radius);
			Console.WriteLine("position: " + x + ", " + y);
		}

		public double DistanceFromOrigin() {
			return Math.Abs(x) + Math.Abs(y);
		}

		public void DoubleSize() {
			radius *= 2;
		}

		public void IncreaseSize(int increase) {
			radius += increase;
		}
	}
}
