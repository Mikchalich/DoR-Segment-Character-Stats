namespace CharacterStaDecoratorExample
{
    class MultiplyStatModifier : StatModifier
    {
        public MultiplyStatModifier(float value) 
            : base(value) { }

        public override float ModifyValue(float baseValue) 
            => baseValue * (1 + Value);
    }
}
