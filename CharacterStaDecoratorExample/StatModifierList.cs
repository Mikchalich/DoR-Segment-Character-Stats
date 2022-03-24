using System.Collections.Generic;

namespace CharacterStaDecoratorExample
{
    internal class StatModifierList
    {
        private readonly List<StatModifier> _statModifiers = new List<StatModifier>();

        public void Add(StatModifier statModifier)
            => _statModifiers.Add(statModifier);

        public bool Remove(StatModifier statModifier)
            => _statModifiers.Remove(statModifier);

        public float Modify(float baseValue)
            => ModifyFlat(ModifyMultiply(ModifyBase(baseValue)));

        private float ModifyBase(float value)
            => _statModifiers.TryParse<BaseStatModifier>().Modify(value);

        private float ModifyMultiply(float value)
            => _statModifiers.TryParse<MultiplyStatModifier>().Modify(value);

        private float ModifyFlat(float value)
            => _statModifiers.TryParse<FlatStatModifier>().Modify(value);
    }
}
