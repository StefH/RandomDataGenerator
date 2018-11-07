using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomDataGenerator.Gui.Extensions
{
    public static class LinqExtensions
    {
        public static int FindIndex1<T>(this IEnumerable<T> items, Predicate<T> predicate)
        {
            return items.TakeWhile(item => !predicate(item)).Count();
        }

        ///<summary>Finds the index of the first item matching an expression in an enumerable.</summary>
        ///<param name="items">The enumerable to search.</param>
        ///<param name="predicate">The expression to test the items against.</param>
        ///<returns>The index of the first matching item, or -1 if no items match.</returns>
        public static int FindIndex<T>(this IEnumerable<T> items, Func<T, bool> predicate)
        {
            if (items == null) throw new ArgumentNullException("items");
            if (predicate == null) throw new ArgumentNullException("predicate");

            int retVal = 0;
            foreach (var item in items)
            {
                if (predicate(item)) return retVal;
                retVal++;
            }

            return -1;
        }
    }
}