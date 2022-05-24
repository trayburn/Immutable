using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immutable
{
    public static class Factory
    {
        private static readonly Random random = new Random(DateTime.Now.Millisecond);

        public static bool IsHeads() => random.Next() % 2 == 0;

        public static PersonClass[] MakePersonClassObjects(int numberOfObjects)
        {
            var retArray = new PersonClass[numberOfObjects];
            for (int i = 0; i < numberOfObjects; i++)
            {
                retArray[i] = new PersonClass() { FirstName = "Timothy", MiddleName = "John", LastName = "Rayburn" };
            }
            return retArray;
        }

        public static PersonRecord[] MakePersonRecordObjects(int numberOfObjects)
        {
            var retArray = new PersonRecord[numberOfObjects];
            for (int i = 0; i < numberOfObjects; i++)
            {
                retArray[i] = new PersonRecord("Timothy", "John", "Rayburn");
            }
            return retArray;

        }
    }
}
