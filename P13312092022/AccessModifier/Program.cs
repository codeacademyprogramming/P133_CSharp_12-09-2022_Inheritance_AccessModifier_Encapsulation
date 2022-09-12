using System;

namespace AccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human(" 234324324   ");

            human.ShowInfo();

            human.Age = 51;
            //Console.WriteLine(human.Age);
            human.Surname = "";

            human.Name = "    a     ";
            Console.WriteLine(human.Name);

            //human.SetAge(51);
            //Console.WriteLine(human.GetAge());

            Student student = new Student("Semed");
        }
    }
}
