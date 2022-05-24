using System;
using System.Linq;

namespace Immutable
{
    public class PersonClass
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public string GetFullName() => $"{FirstName} {MiddleName} {LastName}";
    }
}
