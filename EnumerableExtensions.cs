﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectModelExtensions
{
    public static class EnumerableExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            foreach (var e in enumerable)
            {
                action(e);
            }
        }
    }
}
