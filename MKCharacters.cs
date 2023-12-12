using System;
namespace DataStructures
{
	public class MKCharacters
	{
        public string Name { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }

        public MKCharacters(string name, int health, int strength, int speed)
        {
            Name = name;
            Health = health;
            Strength = strength;
            Speed = speed;
        }
    }
}

