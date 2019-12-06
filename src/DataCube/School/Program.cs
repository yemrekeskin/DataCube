using System;
using System.Linq;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // add student
            //using (var context = new SchoolContext())
            //{
            //    var std = new Student()
            //    {
            //        FirstName = "Bill"
            //    };

            //    context.Students.Add(std);
            //    context.SaveChanges();
            //}

            // querying student or students
            //var context1 = new SchoolContext();
            //var studentsWithSameName = context1.Students
            //                                  .Where(s => s.FirstName == "Bill")
            //                                  .ToList();

            // add
            //using (var context2 = new SchoolContext())
            //{
            //    var std = new Student()
            //    {
            //        FirstName = "Bill",
            //        LastName = "Gates"
            //    };
            //    context2.Students.Add(std);

            //    // or
            //    // context2.Add<Student>(std);

            //    context2.SaveChanges();
            //}

            // update student
            //using (var context3 = new SchoolContext())
            //{
            //    var std = context3.Students.First<Student>();
            //    std.FirstName = "Steve";
            //    context3.SaveChanges();
            //}

            // delete
            using (var context4 = new SchoolContext())
            {
                var std = context4.Students.First<Student>();
                context4.Students.Remove(std);

                // or
                // context4.Remove<Student>(std);

                context4.SaveChanges();
            }

            Console.ReadLine();
        }
    }
}
