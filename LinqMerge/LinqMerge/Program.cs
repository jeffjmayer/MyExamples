using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqMerge
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] firstNames = {"George", "John", "Thomaas", "James", "James"};
            string[] lastNames = {"Washington", "Adams", "Jefferson", "Madison", "Manroe"};

            var fullNames = MergeNames(firstNames, lastNames, AmericanStyleFullName);

            foreach (var fullName in fullNames)
            {
                Console.WriteLine(fullName);
            }
            
            Console.ReadLine();

        }

        private static string BritishStyleFullName(string firstName, string surname)
        {
            return firstName + ", " + surname;
        }

        private static string AmericanStyleFullName(string firstName, string lastName)
        {
            return lastName + ", " + firstName;
        }


        private static IEnumerable<TResult> MergeNames<T, TResult>(IEnumerable<T> sequenceFirst, IEnumerable<T> sequenceSecond, Func<T,T,TResult> mergeFunc)
        {
            using (IEnumerator<T> enumerator1 = sequenceFirst.GetEnumerator())
            using (IEnumerator<T> enumerator2 = sequenceSecond.GetEnumerator())
            {
                while ((enumerator1.MoveNext() && enumerator2.MoveNext()))
                {
                    yield return mergeFunc(enumerator1.Current, enumerator2.Current);
                }
            }
                
            
        }
    }
}
