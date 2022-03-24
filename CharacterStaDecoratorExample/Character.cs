using System;

namespace CharacterStaDecoratorExample
{
    class Character
    {
        public CharacterStat Damage { get; init; }
        public void WriteStat()
        {
            Console.WriteLine($"Damage = {Damage.Value}");
        }
        public Character()
        {
            
        }
    }
}
