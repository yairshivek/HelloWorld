using System;

namespace HelloVSCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Works.Run();
            Student s = new Student(1001);
            //s.SetId(101);
            s.Name  = "Jim";
            s.Grade = 98;
            s.Gender =  EnmGender.Female;


            System.Console.WriteLine("Student Id:{0} Name:{1} Grade:{2} Gender:{3}", s.GetId(), s.Name, s.Grade, s.Gender);
        }
    }
}
