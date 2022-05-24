using System;
using System.Linq;

namespace Immutable.Examples
{
    public class FakeImmutable
    {
        public FakeImmutable(string addressLine1, string addressLine2, string city, string state, string postalCode)
        {
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            City = city;
            State = state;
            PostalCode = postalCode;
        }
        public string AddressLine1 { get; private set; }
        public string AddressLine2 { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string PostalCode { get; private set; }
        public override string ToString()
        {
            return $"{AddressLine1}\r\n{AddressLine2}\r\n{City},{State} {PostalCode}";
        }
    }
}
