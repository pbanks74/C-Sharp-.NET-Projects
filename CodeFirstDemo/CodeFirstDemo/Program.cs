using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentInfo())
            {
                // Create and save a new student
                Console.WriteLine("Enter students name:");
                var name = Console.ReadLine();

                var student = new Student { StudentName = name };
                db.Students.Add(student);
                db.SaveChanges();

                //displays all students from the database
                var query = from b in db.Students
                            orderby b.StudentName
                            select b;

                Console.WriteLine("All students in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.StudentName);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
            }
        }
    }
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public virtual List<Student> Students { get; set; }
    }
    public class StudentInfo : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
