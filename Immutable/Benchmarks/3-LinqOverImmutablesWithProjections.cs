using BenchmarkDotNet.Attributes;
using System;
using System.Linq;

namespace Immutable._1_Class_v_Record
{
    //[MemoryDiagnoser, ThreadingDiagnoser]
    //public class LinqOverImmutablesWithProjections
    //{
    //    const int numberOfObjects = 10000;

    //    [Benchmark]
    //    public PersonClass[] LinqWithProjectionOverClasses()
    //    {
    //        var data = Factory.MakePersonClassObjects(numberOfObjects);
    //        var result = data.Where(x => Factory.IsHeads())
    //            .Select(x => new PersonClass()
    //            {
    //                FirstName = x.FirstName,
    //                MiddleName = x.MiddleName,
    //                LastName = "Jackson"
    //            });
    //        return result.ToArray();
    //    }
    //    [Benchmark]
    //    public PersonRecord[] LinqWithProjectionOverRecords()
    //    {
    //        var data = Factory.MakePersonRecordObjects(numberOfObjects);
    //        var result = data.Where(x => Factory.IsHeads())
    //            .Select(x => x with { lastName = "Jackson" });
    //        return result.ToArray();
    //    }
    //}
}
