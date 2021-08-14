using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTestApplication
{
    public class ArtHistory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Style> Styles { get; set; }

        public ArtHistory(int id, string name, List<Style> styles)
        {
            Id = id;
            Name = name;
            Styles = styles;
        }
    }
}
