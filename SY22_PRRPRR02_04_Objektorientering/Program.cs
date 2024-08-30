using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_04_Objektorientering {
	internal class Program {
		static void Main(string[] args) {
			Circle circle1 = new Circle(5, 2.3, 5, "blue", "Josef");
			Circle circle2 = new Circle(17, 10.5, 5.5, "red", "Martin");

			Console.WriteLine("Före förändring:");
			circle1.DrawSelf();
			circle2.DrawSelf();

			circle1.IncreaseSize(10);
			circle2.DoubleSize();

			Console.WriteLine("Efter förändring:");
			circle1.DrawSelf();
			circle2.DrawSelf();
		}
	}
}
