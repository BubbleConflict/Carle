using System.Collections.Generic;
using System.Linq;

namespace Carle
{
    public static class ListExtensions
    {
        public static List<string> GetDuplicates(this List<string> input)
        {
            return input.GroupBy(p => p)
                        .Where(q => q.Count() > 1)
                        .Select(r => r.Key)
                        .ToList();
        }
    }
}
