using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immutable._1_Class_v_Record
{
    [MemoryDiagnoser, ThreadingDiagnoser]
    public class ClassVsRecord
    {
        const int numberOfObjects = 100;

        [Benchmark]
        public PersonClass[] ClassCreation()
        {
            var retArray = new PersonClass[numberOfObjects];
            for (int i = 0; i < numberOfObjects; i++)
            {
                retArray[i] = new PersonClass() { FirstName = "Timothy", MiddleName = "John", LastName = "Rayburn" };
            }
            return retArray;
        }
        [Benchmark]
        public PersonRecord[] RecordCreation()
        {
            var retArray = new PersonRecord[numberOfObjects];
            for (int i = 0; i < numberOfObjects; i++)
            {
                retArray[i] = new PersonRecord("Timothy", "John", "Rayburn");
            }
            return retArray;

        }

        public class PersonClass
        {
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string LastName { get; set; }

            public string GetFullName() => $"{FirstName} {MiddleName} {LastName}";
        }

        public record PersonRecord(string firstName, string middleName, string lastName);
    }
}
