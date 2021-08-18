using System;

namespace Class__7_Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            var student = new Student();

            student.Name = "Tanjeeb";
            student.Dateofbirth = new DateTime(1993, 7, 31);
            student.Address = "Chittagong,Bangladesh";
            student.Cgpa = 3.14;

            student.Cgpa=3.74;
            Console.WriteLine(student.Cgpa);
            Console.WriteLine(student.Address);

            Student student2 = new Student();

            student2.Cgpa = 3.00;
            student2.Name = "Magix";
            

            student2.Cgpa=3.01;
            student2.Cgpa += 2;

            //AreaCalculater result = new AreaCalculater();

            var re =AreaCalculater.GetCircle(2.5);



            Console.WriteLine(re);

            AreaCalculater.Name = "tanjeeb";

            AreaCalculater t = new AreaCalculater();
            t.print();

            Console.WriteLine(t);



        }

    }
}
