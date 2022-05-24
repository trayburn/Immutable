using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immutable.Examples
{
    public class PersonClass
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public string GetFullName() => $"{FirstName} {MiddleName} {LastName}";
    }
}
