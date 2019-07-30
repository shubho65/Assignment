using System;
using System.Collections.Generic;
using System.Text;

namespace practicecsharp
{

    class Program
    {
        static void Main(string[] args)
        {

            //var payroll = new PayRoll();

            var employee1= new PermaEmployee();
            var employee2 = new TempEmployee();

            ////////////////Below code not working/////////////////why??///////////////
            //payroll.employees[0] = employee1;
            //payroll.employees[1] = employee2;

            //for (int i = 0; i < payroll.employees.Length; i++)
            //{
            //    Console.WriteLine("Salary of {0} employee: {1}", payroll.employees[i].name,payroll.employees[i].CalculateSalary());
            //}

            Console.WriteLine("Salary of {0} employee: {1}", employee1.name, employee1.CalculateSalary());
            Console.WriteLine("Salary of {0} employee: {1}", employee2.name, employee2.CalculateSalary());
        }
    }
    public abstract class Employee
    {
        public string name;
        protected int tenure;
        protected double basicSalary;
        public abstract double CalculateSalary();
    }

    public class PermaEmployee : Employee
    {
        public PermaEmployee()
        {
            name = "permanent";
            tenure = 5;
            basicSalary = 10000;
        }
        public override double CalculateSalary()
        {
            
            return (basicSalary * 4) + (tenure*2.5);
        }

    }

    public class TempEmployee : Employee
    {
        public TempEmployee()
        {
            name = "temporary";
            tenure = 2;
            basicSalary = 5000;
        }
        public override double CalculateSalary()
        {
            basicSalary = 5000;
            return (basicSalary * 2) + (tenure * 0.5);
        }

    }

    class PayRoll
    {
        public Employee[] employees;
       
    }


}
