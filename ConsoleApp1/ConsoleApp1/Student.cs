using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Student
    {
        public int Id { get; set; }

        public static int Count;

        public string Fullname { get; set; }

        public string Subject { get; set; }

        public static int StudentId = 1000;

        public Student(string fullname, string subject)
        {
            Count++;
            Id = Count;
            Fullname = fullname;
            Subject = subject;
        }
        public void GroupName(string word)
        {
            StudentId++;
            word = word.Remove(2).ToUpper() + StudentId;
            Console.WriteLine(word);
        }
        public string Showinfo()
        {
            return $"Fullname:{Fullname}\nSubject:{Subject}\nId:{Id}";
        }
        public override string ToString()
        {
            return Showinfo();
        }
    }
}
