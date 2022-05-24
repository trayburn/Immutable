using System;
using System.Linq;

namespace Immutable.Examples
{
    public static class Factory
    {
        private static readonly Random random = new Random(DateTime.Now.Millisecond);
        private static readonly string[] firstNames = { "Timothy", "Cori", "Christina", "David", "Harold", "Michael" };
        private static readonly string[] middleNames = { "John", "", "", "M.", "", "L" };
        private static readonly string[] lastNames = { "Rayburn", "Drew", "Liles", "O'Hara", "Pulcher", "Perry" };

        public static bool IsHeads() => random.Next() % 2 == 0;
        public static int RollDie() => random.Next(0, 6);

        public static PersonRecord[] MakePersonRecordObjects(int numberOfObjects)
        {
            var retArray = new PersonRecord[numberOfObjects];
            for (int i = 0; i < numberOfObjects; i++)
            {
                var firstName = firstNames[RollDie()];
                var middleName = middleNames[RollDie()];
                var lastName = lastNames[RollDie()];
                retArray[i] = new PersonRecord(firstName, middleName, lastName, 21);
            }
            return retArray;

        }
    }
}
