using System;
using System.Collections.Generic;
using System.Linq;
using Shouldly;

namespace ShouldlyExtension.Aggregates
{
    public static class AggregatesExtension
    {
        public static void ShouldBeEquivalentToLastItem<TInput>(
            this IEnumerable<TInput> enumerable,
            TInput input,
            string customErrorMessage = null)
        {
            var lastItem = enumerable.LastOrDefault();
            if (lastItem == null)
            {
                throw new NullReferenceException("list has not any items");
            }

            lastItem.ShouldBeEquivalentTo(input, customErrorMessage);
        }

        public static void ShouldBeEquivalentToLastItem<TInput, TKey>(
            this IEnumerable<TInput> enumerable,
            Func<TInput, TKey> orderBy,
            TInput input,
            OrderType orderType = OrderType.Ascending,
            string customErrorMessage = null)
        {
            var inputs = enumerable as TInput[] ?? enumerable.ToArray();
            if (!inputs.Any())
            {
                throw new NullReferenceException("list has not any items");
            }

            var afterOrder = orderType == OrderType.Ascending
                ? inputs.OrderBy(orderBy).ToList()
                : inputs.OrderByDescending(orderBy).ToList();

            var lastItem = afterOrder.LastOrDefault();
            lastItem.ShouldBeEquivalentTo(input, customErrorMessage);
        }

        public static void ShouldBeEquivalentToFirstItem<TInput>(this IEnumerable<TInput> enumerable,
            TInput input, string customErrorMessage = null)
        {
            var firstItem = enumerable.FirstOrDefault();
            if (firstItem == null)
            {
                throw new NullReferenceException("list has not any items");
            }

            firstItem.ShouldBeEquivalentTo(input, customErrorMessage);
        }

        public static void ShouldBeEquivalentToFirstItem<TInput, TKey>(
            this IEnumerable<TInput> enumerable,
            Func<TInput, TKey> orderBy,
            TInput input,
            OrderType orderType = OrderType.Ascending,
            string customErrorMessage = null)
        {
            var inputs = enumerable as TInput[] ?? enumerable.ToArray();
            if (!inputs.Any())
            {
                throw new NullReferenceException("list has not any items");
            }

            var afterOrder = orderType == OrderType.Ascending
                ? inputs.OrderBy(orderBy).ToList()
                : inputs.OrderByDescending(orderBy).ToList();

            var firstItem = afterOrder.FirstOrDefault();
            firstItem.ShouldBeEquivalentTo(input, customErrorMessage);
        }
    }
}