//Name: Mekhribon Yusufbekova
//Course: 350H
//Professor: Hao Tang
//Date: Feb 12, 2025
//HW 2a

using System;
using System.Collections.Generic;
using Cards2;
using static Cards2.Rank;

class Program
{
    static void Main(string[] args)
    {

      // loop while there's more input
      string input = Console.ReadLine();

      // Add your code between this comment
     // and the comment below. You can of
     // course add more space between the
     // comments as needed

     // declare a deck variables and create a deck object
     // DON'T SHUFFLE THE DECK
     Deck deck = new Deck();

     Console.WriteLine("\nTask 1: First 5 cards from deck");
     Console.WriteLine("-------");


     int evenCount = 0;
     int oddCount = 0;


     for  (int i = 0; i < 5; i++)
     {

         Card card = deck.TakeTopCard();
         Console.WriteLine($"Card {i + 1}: {card.Rank} of {card.Suit}");


         int value = GetCardValue(card.Rank);
         Console.WriteLine($"Card value: {value}");

         if(value % 2 == 0)
            evenCount++;
         else
            oddCount++;
            
        Console.WriteLine();
     }


     Console.WriteLine($"Number of even values: {evenCount}");
     Console.WriteLine($"Number of odd values: {oddCount}");
     Console.WriteLine();
    
    deck = new Deck();


    List<Card>[] players = new List<Card>[4];
    for (int i = 0; i < 4; i++)

    {
        players[i] = new List<Card>();
    }


// deal 2 cards each to 4 players (deal properly, dealing
// the first card to each player before dealing the
// second card to each player)
for (int round = 0; round < 2; round++)
{
    for(int player = 0; player < 4; player++)
    {
        players[player].Add(deck.TakeTopCard());
    }
}


// deal 1 more card to players 2 and 3
players[1].Add(deck.TakeTopCard());
players[2].Add(deck.TakeTopCard());


// flip all the cards over
Console.WriteLine("All cards have been flipped over");
Console.WriteLine();


// print the cards for player 1
Console.WriteLine("Player 1's cards:");
foreach (Card card in players[0])
 {
    Console.WriteLine($"{card.Rank} of {card.Suit}");
 }  
 Console.WriteLine(); 


// print the cards for player 2
Console.WriteLine("Player 2's cards:");
foreach (Card card in players[1])
{
    Console.WriteLine($"{card.Rank} of {card.Suit}");
}
Console.WriteLine();


// print the cards for player 3
Console.WriteLine("Player 3's cards:");
foreach (Card card in players[2])
{
    Console.WriteLine($"{card.Rank} of {card.Suit}");
}
Console.WriteLine();


   // print the cards for player 4
   Console.WriteLine("Player 4's cards");
   foreach (Card card in players[3])
   {
    Console.WriteLine($"{card.Rank} of {card.Suit}");
    }
}

static int GetCardValue(Rank rank)
{
    switch (rank)
    {
        case Rank.Ace:
           return 1;
        case Rank.Jack:
           return 11;
        case Rank.Queen:
           return 12;
        case Rank.King:
           return 13;
        default:
            return (int)rank;
       }
   }
}


