using Immutable.Examples;
using System.Reflection;

var address = new FakeImmutable("123 Main St.", "Suite 200", "Springfield", "MO", "22222-1111");
var addressType = address.GetType();

Console.WriteLine(address.ToString());


//Console.WriteLine("-----------------------------------------------------------");

//addressType.GetProperty("City").SetValue(address, "Plano");

//Console.WriteLine(address);

//Console.WriteLine("-----------------------------------------------------------");

//var flags = BindingFlags.NonPublic | BindingFlags.Instance;
//var nonPublic = addressType.GetFields(flags);

//foreach (var member in nonPublic)
//{
//    Console.WriteLine(member.Name);
//}

//Console.WriteLine("-----------------------------------------------------------");

//addressType.GetField("<City>k__BackingField", flags).SetValue(address, "Plano");

//Console.WriteLine(address);

