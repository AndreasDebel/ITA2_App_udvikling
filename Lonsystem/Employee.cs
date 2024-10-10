using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PaymentSystem
{
    public class Employee
    {
        string name = "";
        string address = "";
        string email = "";
        public int tax_deduction = 0;
        public int tax_percentage = 0;
        bool lunch_sub = false;
        protected int lunch_price = 350;
        protected int discount_percent = 30;
        bool gift_sub = false;
        int gift_price = 30;

        public int salary = 0;
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

        public void Payslip_txt()
        {
            string[] payslip_lines = new string[11];

            payslip_lines[0] = name;
            payslip_lines[1] = address;
            payslip_lines[2] = "Email: " + email;
            if (set_pay == true) payslip_lines[3] = "Type: Fastansat"; else payslip_lines[3] = "Type: Deltidsansat";
            payslip_lines[4] = $"Månedsløn: {salary} kr.";
            payslip_lines[5] = $"Fradrag: {tax_deduction} kr.";
            payslip_lines[6] = $"Skat: {tax_percentage}% af {salary-tax_deduction} kr. - {EmployeeTaxes()} kr.";
            if (lunch_sub == true) payslip_lines[7] = $"Frokostordning - {lunch_price} kr."; else payslip_lines[7] = "";
            if (gift_sub == true) payslip_lines[8] = $"Gavekasse - {gift_price}"; else payslip_lines[8] = "";
            payslip_lines[9] = "";
            payslip_lines[10] = $"Netto: {EmployeePayout()}";


            string directory = @"C:\Users\Andre\Documents\Lokale Git Repositories\ITA2_App_udvikling\Lonsystem\Payslips_txt\";
            string fileName = GetFirstName() + "_payslip.txt";

            File.WriteAllLines(Path.Combine(directory, fileName), payslip_lines);

            Console.WriteLine("Payslip file created.");
        }


        public int EmployeeTaxes()
        {
            return (salary - tax_deduction) * tax_percentage / 100;
        }

        private int EmployeePayout()
        {
            return salary - EmployeeTaxes();
        }

        private string GetFirstName()
        {
            int spaceIndex = name.IndexOf(' ');
            if (spaceIndex == -1) return name;
            return name.Substring(0, spaceIndex);
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
            lunch_price = lunch_price * discount_percent / 100;
        }
    }
}
