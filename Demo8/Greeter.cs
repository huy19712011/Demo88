using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8
{
    public class Greeter
    {
        public string Greet(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }

            if (name.Trim() == string.Empty)
            {
                throw new ArgumentException("name is empty", "name");
            }

            return $"Hello, {name}";
        }
    }
}
