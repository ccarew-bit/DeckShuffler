using System;
using System.Collections.Generic;

namespace DeckShuffler
{
  class Program
  {
    static void Main(string[] args)
    {
      var suits = new string[] { "clubs", "hearts", "diamonds", "spades" };
      var value = new string[] { "ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king" };
      var card = "";
      var deck = new List<string>();

      for (var i = 0; i < suits.Length; i++)
      {
        for (var j = 0; j < value.Length; j++)
        {
          card = ($"{value[j]} of {suits[i]}");
          deck.Add(card);
        }
      }
      for (var i = deck.Count - 1; i >= 1; i--)
      {
        var j = new Random().Next(i);

        var temp = (deck[j]);
        deck[j] = (deck[i]);
        deck[i] = temp;

      }
      var shuffleAgain = true;
      while (shuffleAgain)
      {
        var topCard = deck[0];
        Console.WriteLine($"this is your {topCard}");
        deck.RemoveAt(0);
        Console.WriteLine("would you like to shuffle or quit?");
        var answer = Console.ReadLine().ToLower();
        if (answer == "shuffle")
        {
          shuffleAgain = true;
        }
        if (answer != "shuffle")
        {
          Console.WriteLine("Thanks for shuffling, goodbye!");
          shuffleAgain = false;
        }
      }





      //Once the program starts, you should create a new deck
      //After deck creation, you should shuffle the deck using Fisher–Yates shuffle algorithm.
      //After the deck is shuffled, display the top card.
      //Give the user an option to see the next card or quit the program.
    }
  }
}
