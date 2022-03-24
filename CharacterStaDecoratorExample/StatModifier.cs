namespace CharacterStaDecoratorExample
{
    public abstract class StatModifier
    {
        private readonly float _value;

        public float Value => _value;

        public StatModifier(float value)
        {
            _value = value;
        }

        public abstract float ModifyValue(float baseValue);
    }
}