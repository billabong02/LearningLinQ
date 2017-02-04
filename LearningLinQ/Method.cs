using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningLinQ
{
    class Method : ILinQ
    {
        public void Syntax()
        {
            string[] countries = { "Pakistan", "Korea", "Philippines", "USA", "UAE", "UK", "Germany" };

            //var _countries = countries.Where(c => c.StartsWith("U") && c.Length > 2);

            Console.WriteLine("The countries that start with U are as follows:");

            foreach (var _countries in countries.Where(c => c.StartsWith("U") && c.Length > 2))
            {
                Console.WriteLine(_countries);
            }

            Console.WriteLine("");
            Console.WriteLine("This query was executed using the method syntax!");
            Console.ReadLine();
        }
    }
}
