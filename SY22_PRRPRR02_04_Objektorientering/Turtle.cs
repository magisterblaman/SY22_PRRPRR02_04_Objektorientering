using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_04_Objektorientering {
	internal class Turtle {
		public int size;
		public string color;
		public string name;

		public Turtle(int inputSize,
			string inputColor,
			string inputName) {

			size = inputSize;
			color = inputColor;
			name = inputName;
		}

		public void PrintGreeting() {
			Console.WriteLine("Jag heter " + name + ", är "
				+ color + " och " + size + "cm lång");
		}
	}
}
