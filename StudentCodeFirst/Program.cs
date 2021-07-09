using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                var student = new Student() { Name = " Deepak Bandhu" };

                var mathSub = new Subject() { Name = "Math" };
                var englishSub = new Subject() { Name = "English" };

                student.Subjects.Add(mathSub);
                student.Subjects.Add(englishSub);

                db.Students.Add(student);
                db.SaveChanges();
            }
        }
    }

    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }

        public virtual List<Subject> Subjects { get; set; }

        public Student()
        {
            this.Subjects = new List<Subject>();
        }
    }

    public class Subject
    {
        public int SubjectID { get; set; }
        public string Name { get; set; }

        public virtual Student Student { get; set; }
    }

    class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }

    }
}
