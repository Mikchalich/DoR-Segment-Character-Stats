using System;

namespace CharacterStaDecoratorExample
{
    internal abstract class CharacterStat
    {
        private readonly StatModifierList _statModifiers = new StatModifierList();

        public CharacterStat(float baseValue) 
        {
            BaseValue = baseValue;
        }

        public float BaseValue { get; }

        public float Value => CalculateFinalValue();

        public void AddModifier(StatModifier statModifier) 
            => _statModifiers.Add(statModifier);

        public bool RemoveModifier(StatModifier statModifier) 
            => _statModifiers.Remove(statModifier);

        private float CalculateFinalValue() 
            => _statModifiers.Modify(BaseValue).Round(2);
    }
}
