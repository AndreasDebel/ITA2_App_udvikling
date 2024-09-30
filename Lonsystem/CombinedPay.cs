using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystem
{
    public class AllEmployees
    {
        private List<Employee> employeeList;
        
        
        
        
        public int Calc_CombinedPay(List<Employee> Employees)
        {
            int sum = 0;
            for (int i = 0; i < Employees.Count; i++)
            {
                sum = sum + Employees[i].salary;
            }
            return sum;
        }
    }
}
