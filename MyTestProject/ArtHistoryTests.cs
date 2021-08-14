using ConsoleTestApplication;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace MyTestProject
{
    class ArtHistoryTests
    {
        [Test]
        public void CreateField()
        {
            var field1 = new Field(1, "malarstwo");
            Assert.IsTrue(field1.Id == 1 && field1.Name == "malarstwo");
        }

        [Test]
        public void CreateStyle()
        {
            var field1 = new Field(1, "malarstwo");
            var fields = new List<Field>();

            fields.Add(field1);

            var style = new Style(1, "barok", fields);
            Assert.IsTrue(style.Id == 1 && style.Name == "barok" && style.Fields.Any(f => f.Id == 1 && f.Name == "malarstwo"));
        }

        [Test]
        public void CreateArtHistory()
        {
            var fields = new List<Field>();
            var styles = new List<Style>();

            var artHistory = new ArtHistory(1, "olimpiada", styles);

            Assert.IsTrue(artHistory.Id == 1 && artHistory.Name == "olimpiada" && artHistory.Styles == styles);
        }
    }
}
