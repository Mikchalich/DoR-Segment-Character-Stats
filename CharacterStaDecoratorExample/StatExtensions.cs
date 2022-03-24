using System;
using System.Collections.Generic;
using System.Linq;

namespace CharacterStaDecoratorExample
{
    internal static class StatExtensions
    {
        public static IEnumerable<T> TryParse<T>(this IEnumerable<StatModifier> self)
            where T : StatModifier
        {
            foreach (var stat in self)
                if (stat is T tStat)
                    yield return tStat;
        }

        public static float Modify(this IEnumerable<BaseStatModifier> self, float baseValue)
            => new BaseStatModifier(ConcatModifiers(self)).ModifyValue(baseValue);

        public static float Modify(this IEnumerable<MultiplyStatModifier> self, float baseValue) 
            => new MultiplyStatModifier(ConcatModifiers(self)).ModifyValue(baseValue);

        public static float Modify(this IEnumerable<FlatStatModifier> self, float baseValue)
            => new FlatStatModifier(ConcatModifiers(self)).ModifyValue(baseValue);

        public static float Round(this float self, int decimals = 0)
            => (float)Math.Round(self, decimals);

        private static float ConcatModifiers(IEnumerable<StatModifier> statModifiers) 
            => statModifiers.Sum(stat => stat.Value);
    }
}
