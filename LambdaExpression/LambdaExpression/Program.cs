using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    public class Program
    {
        static void Main(string[] args)
        {

            // created 10 employees
            Employee emp1 = new Employee();
            emp1.Firstname = "Joe";
            emp1.LastName = "Pickerington";
            emp1.Id = 001;

            Employee emp2 = new Employee();
            emp2.Firstname = "Sandy";
            emp2.LastName = "Rogue";
            emp2.Id = 002;

            Employee emp3 = new Employee();
            emp3.Firstname = "Joe";
            emp3.LastName = "Basilmore";
            emp3.Id = 003;

            Employee emp4 = new Employee();
            emp4.Firstname = "Julie";
            emp4.LastName = "Steigal";
            emp4.Id = 004;

            Employee emp5 = new Employee();
            emp5.Firstname = "Roger";
            emp5.LastName = "Rabbit";
            emp5.Id = 005;

            Employee emp6 = new Employee();
            emp6.Firstname = "Paul";
            emp6.LastName = "Samuelson";
            emp6.Id = 006;

            Employee emp7 = new Employee();
            emp7.Firstname = "George";
            emp7.LastName = "Strait";
            emp7.Id = 007;

            Employee emp8 = new Employee();
            emp8.Firstname = "Samantha";
            emp8.LastName = "Edgerington";
            emp8.Id = 008;

            Employee emp9 = new Employee();
            emp9.Firstname = "Stevie";
            emp9.LastName = "Knicks";
            emp9.Id = 009;

            Employee emp10 = new Employee();
            emp10.Firstname = "Bob";
            emp10.LastName = "Bobber";
            emp10.Id = 010;

            // created a list and added employees
            List<Employee> Employees = new List<Employee>();
            Employees.Add(emp1);
            Employees.Add(emp2);
            Employees.Add(emp3);
            Employees.Add(emp4);
            Employees.Add(emp5);
            Employees.Add(emp6);
            Employees.Add(emp7);
            Employees.Add(emp8);
            Employees.Add(emp9);
            Employees.Add(emp10);


            // created a new list to add employees to
            List<Employee> DuplicateEmployees = new List<Employee>();

            //  foreach loop that adds employees with the name Joe to new list
            foreach (Employee Employee in Employees)
            {
                if (Employee.Firstname == "Joe")
                {
                    
                    DuplicateEmployees.Add(Employee);
                }
            }
            Console.WriteLine(DuplicateEmployees);
            Console.ReadLine();

        }
    }
}
