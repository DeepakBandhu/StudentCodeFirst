This project is dedicated to learning a code first program and it includes the two methods being set up so a student and their classes they are taking are scaffolded along with them.

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


This is what was set up before scaffolding, along the Db get set.
