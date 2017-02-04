using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningLinQ
{
    class Query : ILinQ
    {
        public void Syntax()
        {
            string[] countries = { "Pakistan", "Korea", "Philippines", "USA", "UAE", "UK", "Philippines" };

            var _countries = from c in countries
                             where c.StartsWith("U")
                             && c.Length > 2
                             select c;

            Console.WriteLine("The countries that start with U are as follows:");

            foreach (var country in _countries)
            {
                Console.WriteLine(country);
            }

            Console.WriteLine("");
            Console.WriteLine("This query was executed using the query syntax!");
            Console.ReadLine();
        }
    }
}
