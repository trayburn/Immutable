using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immutable._1_Class_v_Record
{
    //[MemoryDiagnoser, ThreadingDiagnoser]
    //public class ClassVsRecord
    //{
    //    const int numberOfObjects = 10000;

    //    [Benchmark]
    //    public PersonClass[] ClassCreation() => Factory.MakePersonClassObjects(numberOfObjects);
    //    [Benchmark]
    //    public PersonRecord[] RecordCreation() => Factory.MakePersonRecordObjects(numberOfObjects);
    //}
}
