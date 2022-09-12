using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Hamid");
            human.SurName = "Mammadov";
            human.Age = 32;

            Student student = new Student("Semed", "Aliyev");
            student.Age = 20;
            student.Grade = 20;
            student.Education = "Code Academy";

            Developer developer = new Developer("", "");

            developer.ShowInfo();

            Console.WriteLine(student.Name);
            Console.WriteLine(human.Name);
        }
    }
}
