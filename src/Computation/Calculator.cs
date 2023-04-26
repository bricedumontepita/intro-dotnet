using System.Linq;

namespace Computation
{
    public class Calculator
    {
        public int SumNumbers(int start, int count)
        {
            // return Enumerable.Range(start, count).Sum();
            // Enumerable.Range(start, count).Aggregate(0, (res, elt) => res + elt)
            return Enumerable.Aggregate(Enumerable.Range(start, count), 0, (result, elt) => result + elt);
        }
    }
}
