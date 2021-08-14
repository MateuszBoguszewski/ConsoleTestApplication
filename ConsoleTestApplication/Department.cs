using System.Collections.Generic;

namespace ConsoleTestApplication
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }

        public Department(int id, string name, List<Student> students)
        {
            Id = id;
            Name = name;
            Students = students;
        }
    }
}
