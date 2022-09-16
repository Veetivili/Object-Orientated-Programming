using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;

namespace T10_Student
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
        string Mail = "@school.fi";
        public string studentMail => $"{Id}{Mail}";

        public Student(int id, string name, string group)
        {
            Id = id;
            Name = name;
            Group = group;
        }
        

        public string ShowInfo()
        {
            return $" Student id: {Id}, Name: {Name}, Group: {Group}, Mail: {studentMail}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = { new Student(8461, "Jesse", "LAP212"), new Student(7491, "Tiina", "KPR311"), new Student(1470, "Toni", "TXI412"), new Student(1552, "Hannele", "TIC222"), new Student(6772, "Osmo", "KPR311") };
            foreach (Student student in students)
            { Console.WriteLine(student.ShowInfo()); }
        }
    }
}

