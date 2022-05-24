using Immutable.Examples;
using System.Reflection;

void line() => Console.WriteLine("-----------------------------------------------------------");
void banner(string text)
{
    line();
    Console.WriteLine(text);
    line();
}

//banner("Not Truly Immutable");

//var address = new FakeImmutable("123 Main St.", "Suite 200", "Springfield", "MO", "22222-1111");
//var addressType = address.GetType();

//Console.WriteLine(address.ToString());

//line()

//addressType.GetProperty("City").SetValue(address, "Plano");

//Console.WriteLine(address);

//line()

//var flags = BindingFlags.NonPublic | BindingFlags.Instance;
//var nonPublic = addressType.GetFields(flags);

//foreach (var member in nonPublic)
//{
//    Console.WriteLine(member.Name);
//}

//line()

//addressType.GetField("<City>k__BackingField", flags).SetValue(address, "Plano");

//Console.WriteLine(address);

//line();

//var person = new PersonRecord("Timothy", "John", "Rayburn", 21);
//var personType = person.GetType();

//Console.WriteLine(person.ToString());

//line();

//var flags = BindingFlags.NonPublic | BindingFlags.Instance;
//var nonPublic = personType.GetFields(flags);

//foreach (var member in nonPublic)
//{
//    Console.WriteLine(member.Name);
//}

//line();

//personType.GetField("<lastName>k__BackingField", flags).SetValue(person, "Christopher");

//Console.WriteLine(person);

//line();


//banner("Pattern Matching");

//var data = Factory.MakePersonRecordObjects(1000);
//foreach (var row in data)
//{
//    var msg = row switch
//    {
//        { firstName: "Cori", lastName: "O'Hara" } => row,
//        _ => null
//    };
//    if (msg is not null) Console.WriteLine(msg);
//}

//banner("Mapping Objects is the Worst");

//var data = Factory.MakePersonRecordObjects(1000);
//foreach (var row in data)
//{
//    var msg = row switch
//    {
//        { firstName: "Harold", lastName: "O'Hara" } => row with { lastName = "Pulcher"},
//        _ => null
//    };
//    if (msg is not null) Console.WriteLine(msg);
//}

//banner("Deconstructing Records");

//var singlePerson = Factory.MakePersonRecordObjects(1).First();

//var (firstName, _, lastName, age) = singlePerson;

//Console.WriteLine($"{firstName} {lastName} (age {age})");