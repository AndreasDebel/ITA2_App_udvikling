using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystem
{
    public class Test_AllEmployees
    {
        public static void Run()
        {
            // Create instance of AllEmployees
            AllEmployees EAAA_Employees = new AllEmployees();

            // Create and add employees to the list
            List<Employee> employeeList = new List<Employee>
            {
                new Permanent_Emp("Poul Hansen", "Hammershusvej 40", "poul@eaaa.dk", 5000, 36, true, true, 36000),
                new Permanent_Emp("Hanne Sederstrøm", "Niels Andersensgade 2", "hanne@eaaa.dk", 8000, 37, true, true, 41000),
                new Hourly_Emp("Børge Fink Funkers", "Fløjsvænget 108 3 th", "anders@eaaa.dk", 5500, 32, false, false, 90, 165)
            };

            int combinedSalary = EAAA_Employees.Calc_CombinedPay(employeeList);

            Console.WriteLine($"De ansattes samlede løn er: {combinedSalary} kr.");
            Console.WriteLine($"De ansatte betaler til sammen {EAAA_Employees.Calc_CombinedTaxes(employeeList)} kr. i skat");

            foreach ( Employee emp in employeeList )
            {
                emp.Payslip_txt();
            }
        }
    }
}
