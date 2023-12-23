﻿using System.Linq.Expressions;

namespace ApplicationManagementSystem.Core.Extensions.Linq
{
    public static class QueryableExtensions
    {
        public static IQueryable<T> WhereIf<T>(this IQueryable<T> query, bool condition, Expression<Func<T, bool>> predicate)
        {
            return condition ? query.Where(predicate) : query;
        }
        public static IQueryable<T> PageBy<T>(this IQueryable<T> query, int skipCount, int maxResultCount)
        {
            return query.Skip(skipCount).Take(maxResultCount);
        }
    }
}
