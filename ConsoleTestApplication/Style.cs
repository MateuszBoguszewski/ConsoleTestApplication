using System.Collections.Generic;

namespace ConsoleTestApplication
{
    public class Style
    {
        private int v1;
        private string v2;
        private Field field1;
        private int v;

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Field> Fields { get; set; }

        public Style(int id, string name, List<Field> fields)
        {
            Id = id;
            Name = name;
            Fields = fields;
        }

        public Style(int v1, string v2, Field field1)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.field1 = field1;
        }

        public Style(int v, Field field1)
        {
            this.v = v;
            this.field1 = field1;
        }
    }
}
