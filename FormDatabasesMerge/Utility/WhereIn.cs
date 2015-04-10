using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormDatabasesMerge.Utility
{
    public static class WhereIn
    {
        public static bool In<T>(this T source, params T[] list)
        {
            return list.Contains(source);
        }
    }
}
