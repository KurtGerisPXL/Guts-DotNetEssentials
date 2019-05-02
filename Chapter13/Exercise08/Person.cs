using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise08
{
    public class Person
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string TelephoneNumber { get; set; }
        public DateTime BirthDate { get; set; }

        public override string ToString()
        {
            return $"{Name} {FirstName}";
        }
    }
}