using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
//Gabrielle Vidal
//Credit to assignment tutorial on canvas
//Credit to Janell Baxter for Apples and Oranges card game

namespace Vidal_Shuffle;
class Program
{
    static void Main(string[] args)
    {
        string[] Cards = { "Ace of Apples", "2 of Apples", "3 of Apples", "4 of Apples", "5 of Apples", "6 of Apples", "7 of Apples", "8 of Apples", "9 of Apples", "10 of Apples", "Jack of Apples", "Queen of Apples", "King of Apples", "Ace of Oranges", "2 of Oranges", "3 of Oranges", "4 of Oranges", "5 of Oranges", "6 of Oranges", "7 of Oranges", "8 of Oranges", "9 of Oranges", "10 of Oranges", "Jack of Oranges", "Queen of Oranges", "King of Oranges" };

        WriteLine("Cards before shuffle: \n");

        foreach (string card in Cards)
        {
            WriteLine(card);
        }
        WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Random randomNumber = new Random();
        int randomElement = randomNumber.Next(Cards.Length);
        string temp = Cards[randomElement];
        Cards[randomElement] = Cards[0];
        Cards[0] = temp;
        WriteLine("\nCards after shuffle: \n");
        foreach (string card in Cards)
        {
            WriteLine(card);
        }
        ReadKey();
    }
}

