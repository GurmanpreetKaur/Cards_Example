using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Gurmanpreet Kaur
 * Date: July 27, 2017
 * Description: This is a demo for Lesson 11
 * Version: 0.5 - Tested the new Deal5 method
 */

namespace Cards_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Hand hand = new Hand();

            Console.WriteLine(deck.ToString());
            Console.WriteLine();
            deck.Shuffle();
            Console.WriteLine("Shuffled");
            Console.WriteLine(deck.ToString());

            hand.Add(deck.Deal1());
            Console.WriteLine(hand.ToString());
            Console.WriteLine();
            hand.Add(deck.Deal1());
            Console.WriteLine(hand.ToString());

            Console.WriteLine();
            Console.WriteLine(deck.ToString());

            //hand = deck.Deal5(); // moves the top 5 cards from the deck to the hand object

            deck.Shuffle();
            Console.WriteLine("Shuffled");
            Console.WriteLine(deck.ToString());
            Console.WriteLine("Dealt Top Five Cards");
            Console.WriteLine("==================================");
            Console.WriteLine();
            hand = deck.Deal5();

            Console.WriteLine(hand.ToString());
            hand.HighestCards(hand);


        }
    }
}
