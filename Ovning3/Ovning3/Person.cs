using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3
{
    class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        public int Age { get => age; set => age = value; }
        public string FName { get => fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }
        public double Height { get => height; set => height = value; }
        public double Weight { get => weight; set => weight = value; }
    }
}
