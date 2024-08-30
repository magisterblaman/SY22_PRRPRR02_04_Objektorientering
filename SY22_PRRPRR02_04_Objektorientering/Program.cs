using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_04_Objektorientering {
	internal class Program {
		static void Main(string[] args) {
			Turtle turtle1 = new Turtle(22, "rosa", "Pinky");

			turtle1.PrintGreeting();

			Turtle turtle2 = new Turtle(turtle1.size, 
				turtle1.color, 
				turtle1.name);

			turtle2.PrintGreeting();

			Console.WriteLine("-------");

			turtle1.size += 10;

			turtle1.PrintGreeting();
			turtle2.PrintGreeting();
		}
	}
}
