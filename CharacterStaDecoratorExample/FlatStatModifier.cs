namespace CharacterStaDecoratorExample
{
    public class FlatStatModifier : StatModifier
    {
        public FlatStatModifier(float value) 
            : base(value) { }

        public override float ModifyValue(float baseValue) 
            => baseValue + Value;
    }
}
