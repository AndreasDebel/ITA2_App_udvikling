using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystem
{
    public class Employee
    {
        string name = "";
        string address = "";
        string email = "";
        int tax_deduction = 0;
        int tax_percentage = 0;
        bool lunch_sub = false;
        bool gift_sub = false;

        protected int salary = 0;
        bool set_pay;

        public Employee(string name, string address, string email, int tax_ded, int tax_per, bool lunch_sub, bool gift_sub)
        {
            this.name = name;
            this.address = address;
            this.email = email;
            this.tax_deduction = tax_ded;
            this.tax_percentage = tax_per;
            this.lunch_sub = lunch_sub;
            this.gift_sub = gift_sub;
        }


    }

    public class Permanent_Emp : Employee
    {
        bool set_pay = true;

        public Permanent_Emp(string name, string address, string email, int tax_ded, int tax_per, bool lunch_sub, bool gift_sub, int salary)
            : base(name, address, email, tax_ded, tax_per, lunch_sub, gift_sub)
        {
            this.salary = salary;
        }

    }

    public class Hourly_Emp : Employee
    {
        bool set_pay = false;
        int monthly_hours = 0;
        int hourly_pay = 0;


        public Hourly_Emp(string name, string address, string email, int tax_ded, int tax_per, bool lunch_sub, bool gift_sub, int monthly_hours, int hourly_pay)
            : base(name, address, email, tax_ded, tax_per, lunch_sub, gift_sub)
        {
            this.monthly_hours = monthly_hours;
            this.hourly_pay = hourly_pay;
            salary = monthly_hours * hourly_pay;
        }
    }
}
