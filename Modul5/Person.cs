using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5
{
    public class Person
    {
        public string name = "";
        public DateOnly birthday;
        public bool isMale;
        public int height;
        public int weight;

        public Person(string name, DateOnly birthday, bool isMale, int height, int weight)
        {
            this.name = name;
            this.birthday = birthday;
            this.isMale = isMale;
            this.height = height;
            this.weight = weight;
        }

        public double CalcBMI()
        {
            double heightM = height / 100.0;
            double BMI = weight / (heightM * heightM);
            return Math.Round(BMI, 2);
        }

    }
}
