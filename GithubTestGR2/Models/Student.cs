namespace GithubTestGR2.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        //alskfijebghhguhegjw
        //DIMsdimS

        public Student(int id, string name, int age)
        {
            Name = name;
            Age = age;  
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
