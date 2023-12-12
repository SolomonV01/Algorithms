namespace DataStructures;
class Program
{
    static void DisplayCharacter(MKCharacters character)
    {
        Console.WriteLine($"Name: {character.Name}, Health: {character.Health}, Strength: {character.Strength}, Speed: {character.Speed}");
    }

    static void Main()
    {
        // Mortal Kombat 1 Roster
        var roster = new List<MKCharacters>
        {
            new MKCharacters("Smoke", 100, 80, 70),
            new MKCharacters("Sub-Zero", 95, 85, 65),
            new MKCharacters("Scorpion", 90, 75, 75),
            new MKCharacters("Johnny Cage", 110, 70, 80),

        };

        //Array
        MKCharacters[] arrayStorage = roster.ToArray();

        //Stack
        Stack<MKCharacters> stackStorage = new Stack<MKCharacters>(roster);

        //Queue
        Queue<MKCharacters> queueStorage = new Queue<MKCharacters>(roster);

        Console.WriteLine("Characters in Array:");
        foreach (var character in arrayStorage)
        {
            DisplayCharacter(character);
        }

        Console.WriteLine("\nCharacters in Stack:");
        while (stackStorage.Count > 0)
        {
            var character = stackStorage.Pop();
            DisplayCharacter(character);
        }

        Console.WriteLine("\nCharacters in Queue:");
        while (queueStorage.Count > 0)
        {
            var character = queueStorage.Dequeue();
            DisplayCharacter(character);
        }
    }
}