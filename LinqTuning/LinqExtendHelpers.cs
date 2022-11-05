using System;
using System.Collections.Generic;

namespace LinqTuning
{
    internal static class LinqExtendHelpers
    {

        public static List<Student> AnWhere(this List<Student> resource, Func<Student, bool> func)
        {
            List<Student> list = new List<Student>();
            foreach (var item in resource)
            {
                if (func.Invoke(item))
                {
                    list.Add(item);
                }
            }
            return list;
        }
        public static IEnumerable<TSource> AnWhere<TSource>(this IEnumerable<TSource> source,Func<TSource,bool> predicate)
        {
            List<TSource> sourceList = new List<TSource>();
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    sourceList.Add(item);
                }
            }
            return sourceList;
        }
    }
}