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
        private string _CPR;
        public bool isMale;
        public int height;
        public int weight;

        public Person(string name, string cpr, bool isMale, int height, int weight)
        {
            this.name = name;
            this.isMale = isMale;
            CPR = cpr;
            this.height = height;
            this.weight = weight;
        }

        public string CPR
        {

            get { return _CPR; }
            set
            {


                //Console.WriteLine($"Validating CPR: {value} | Last Digit: {lastDigit} | Gender: {(isMale ? "Male" : "Female")}");

                if (value.Length != 10)
                {
                    throw new ArgumentException("CPR must be exactly 10 digits long");
                }

                string firstTwoDigits = value.Substring(0, 2);
                int day = int.Parse(firstTwoDigits);

                if (day < 1 || day > 31)
                {
                    throw new ArgumentException("The day has to be a number between 01 and 31");
                }

                string ThirdAndFourthDigits = value.Substring(2, 2);
                int month = int.Parse(ThirdAndFourthDigits);

                if (month < 1 || month > 12)
                {
                    throw new ArgumentException("The month has to be a number between 01 and 12");
                }

                switch (month)
                {
                    case 2:
                        if (day > 29) throw new ArgumentException("February cannot have more than 29 days.");
                        break;

                    case 4:
                        if (day > 30) throw new ArgumentException("April cannot have more than 30 days.");
                        break;

                    case 6:
                        if (day > 30) throw new ArgumentException("June cannot have more than 30 days.");
                        break;

                    case 9:
                        if (day > 30) throw new ArgumentException("September cannot have more than 30 days.");
                        break;

                    case 11:
                        if (day > 30) throw new ArgumentException("November cannot have more than 30 days.");
                        break;
                }

                int lastDigit = int.Parse(value.Substring(9, 1));
                if (lastDigit % 2 == 0 && isMale == true) throw new ArgumentException("The CPR number has to be odd if the person is male.");
                if (lastDigit % 2 == 1 && isMale == false) throw new ArgumentException("The CPR number has to be even if the person is female.");

                string FifthAndSixthDigit = value.Substring(4, 2);
                int year = int.Parse(FifthAndSixthDigit);
                year += year < 25 ? 2000 : 1900;

                birthday = new DateOnly(year, month, day);

                _CPR = value;
            }
        }



        public double CalcBMI()
        {
            double heightM = height / 100.0;
            double BMI = weight / (heightM * heightM);
            return Math.Round(BMI, 2);
        }

        public bool IsTeenager()
        {
            DateTime today = DateTime.Now;
            DateTime birthday_DT = birthday.ToDateTime(new TimeOnly(0, 0));
            int age = today.Year - birthday_DT.Year;
            if (age >= 13 && age <= 19) return true; else return false;
        }

    }
}
