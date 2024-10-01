using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystem
{
    public class AllEmployees
    {
        private List<Employee> employeeList = new();
        
        
        
        
        public int Calc_CombinedPay(List<Employee> employeeList)
        {
            int sum = 0;
            for (int i = 0; i < employeeList.Count; i++)
            {
                sum = sum + employeeList[i].salary;
            }
            return sum;
        }

        public int Calc_CombinedTaxes(List<Employee> employeeList)
        {
            int sum = 0;
            foreach (Employee employee in employeeList)
            {
                sum = sum + employee.EmployeeTaxes();
            }
            return sum;
        }
    }
}
