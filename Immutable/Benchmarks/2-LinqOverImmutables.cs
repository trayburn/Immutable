using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using System;
using System.Linq;

namespace Immutable._1_Class_v_Record
{
    [MemoryDiagnoser, ThreadingDiagnoser]
    public class LinqOverImmutables
    {
        const int numberOfObjects = 10000;

        [Benchmark]
        public PersonClass[] LinqOverClasses()
        {
            var data = Factory.MakePersonClassObjects(numberOfObjects);
            var result = data.Where(x => Factory.IsHeads());
            return result.ToArray();
        }
        [Benchmark]
        public PersonRecord[] LinqOverRecords()
        {
            var data = Factory.MakePersonRecordObjects(numberOfObjects);
            var result = data.Where(x => Factory.IsHeads());
            return result.ToArray();
        }
    }
}
