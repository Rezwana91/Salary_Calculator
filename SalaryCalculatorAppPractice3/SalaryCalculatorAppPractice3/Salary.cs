using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorAppPractice3
{
   public class Salary
   {
       public string employeeName;
       public double totalSalary;

        public string Calculate(double basicAmount, double houseRent, double medical)
        {
            totalSalary = basicAmount + (basicAmount / houseRent) + (basicAmount / medical);
            string message = employeeName + " " + "your salary is" + " " + totalSalary;
            return message;

        }

    }

   
}
