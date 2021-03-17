using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("shola", "shekoni", (decimal)800000.50);
            Employee emp2 = new Employee("bigsam", "blackie", (decimal)400000.25);

            Console.WriteLine("Employee 1 First Name: {0}", emp1.FirstName);
            Console.WriteLine("Employee 1 Last Name: {0}", emp1.LastName);
            Console.WriteLine("Employee 1 Salary: {0:C}", emp1.Salary);

            Console.WriteLine("Employee 2 First Name: {0}", emp2.FirstName);
            Console.WriteLine("Employee 2 Last Name: {0}", emp2.LastName);
            Console.WriteLine("Employee 2 Salary: {0:C}", emp2.Salary);

            Console.WriteLine();
            Console.WriteLine("After 10% raise");

            emp1.Salary = emp1.Salary * (decimal)1.1;
            emp2.Salary = emp2.Salary * (decimal)1.1;
            Console.WriteLine("Employee 1 new salary: {0:C}", emp1.Salary);
            Console.WriteLine("Employee 2 new salary: {0:C}", emp2.Salary);


            Console.ReadLine();


        }
    }
}