namespace CharacterStaDecoratorExample
{
    internal class BaseStatModifier : StatModifier
    {
        public BaseStatModifier(float value) 
            : base(value) { }

        public override float ModifyValue(float baseValue) 
            => baseValue + Value;
    }
}
