using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApp
{
    class Program
    {
        public class Relative
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public Char Sex { get; set; }
        }
        public class Developer
        {
            public string Name;
            public string Language;
            public int Age;
        }
        static void Main(string[] args)
        {
            Developer[] developers = new Developer[]
            {
                new Developer {Name="Paolo", Language="C#" },
                new Developer {Name="Marco", Language="C#" },
                new Developer {Name="Frank", Language="Vb.NET" }
            };

            var developerUsingCSharp =
                from d in developers
                where d.Language == "C#"
                select d.Name;

            foreach (var item in developerUsingCSharp)
            {
                Console.WriteLine(item);
            }


            var siblings = new List<Relative>
            {
                new Relative {Name = "Kendall", Age = 40, Sex = 'M' },
                new Relative {Name = "Guy", Age = 32, Sex = 'M' },
                new Relative {Name = "Wood", Age = 33, Sex = 'F' },
                new Relative {Name = "James", Age = 31, Sex = 'M' },
            };

            var brothers =
                from s in siblings
                where s.Sex == 'M'
                select s.Name;

            foreach (var item in brothers)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
