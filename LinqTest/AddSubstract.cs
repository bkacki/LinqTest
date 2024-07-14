using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTest
{
    internal class AddSubstract
    {
        public int Value { get; set; }

        public AddSubstract Add(int i)
        {
            Console.WriteLine($"Wartość: {Value}, dodawanie {i}");
            return new AddSubstract() { Value = Value + i };
        }

        public AddSubstract Substract(int i)
        {
            Console.WriteLine($"Wartość: {Value}, odejmowanie {i}");
            return new AddSubstract() { Value = Value - i};
        }
    }
}
