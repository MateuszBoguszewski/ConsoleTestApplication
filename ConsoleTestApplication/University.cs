using System.Collections.Generic;

namespace ConsoleTestApplication
{
    public class University
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Department> Departments { get; set; }
        
        
        public University(int id, string name, List<Department> departments)
        {
            Id = id;
            Name = name;
            Departments = departments;
        }

    }
}
