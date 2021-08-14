namespace ConsoleTestApplication
{
    public class Field
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Field(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
