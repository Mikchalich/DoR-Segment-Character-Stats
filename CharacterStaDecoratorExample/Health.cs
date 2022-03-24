namespace CharacterStaDecoratorExample
{
    internal class Health : CharacterStat
    {
        public float CurrentValue { get; private set; }

        public Health(float baseValue) 
            : base(baseValue) 
        {
            CurrentValue = baseValue;
        }

        public void Kill() 
            => CurrentValue = 0;
    }
}
