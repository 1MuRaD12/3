using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Fullname");
            string fullname = Console.ReadLine();
            Console.WriteLine("Enter Subject");
            string subject = Console.ReadLine();
            Console.WriteLine("Enter GroupName");
            string groupname = Console.ReadLine();
            Student student = new Student(fullname, subject);
            Console.WriteLine(student.ToString());
            student.GroupName(groupname);
            Console.WriteLine("\n--------------------------------\n");
            Console.WriteLine("Enter Fullname");
            string fullname1 = Console.ReadLine();
            Console.WriteLine("Enter Subject");
            string subject1 = Console.ReadLine();
            Console.WriteLine("Enter GroupName");
            string groupname1 = Console.ReadLine();         
            Student student1 = new Student(fullname1, subject1);
            Console.WriteLine(student1.ToString());
            student1.GroupName(groupname1);
          
            

        }
    }
}
