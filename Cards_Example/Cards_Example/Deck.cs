﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Gurmanpreet Kaur
 * Date: July 27, 2017
 * Description: This is the Deck class
 * It inherits from the List generic and uses Card as the base type
 * Version: 0.3 - Refactored Shuffle Method
 */

namespace Cards_Example
{
    public class Deck : List<Card>
    {
        // PRIVATE INSTANCE VARIABLES
        private Random _random;

        // PRIVATE PROPERTIES
        private Random Random
        {

            get
            {
                return this._random;
            }
        }

        // PUBLIC PROPERTIES

        // CONSTRUCTOR
        /// <summary>
        /// This is the main constructor.
        /// </summary>
        public Deck()
        {
            this._initialize();
        }

        // PRIVATE METHODS

        /// <summary>
        /// This is the Initialize method it sets values for private variables
        /// and public properties as well as other class objects.
        /// </summary>
        private void _initialize()
        {
            // initialize the pseudo-random number generator
            this._random = new Random();

            // This builds the deck - fills it with cards
            for (int suit = (int)Suit.Clubs; suit <= (int)Suit.Spades; suit++)
            {
                for (int face = (int)Face.Ace; face <= (int)Face.King; face++)
                {
                    this.Add(new Card((Face)face, (Suit)suit));
                }
            }
        }

        // PUBLIC METHODS

        /// <summary>
        /// This method overrides the built-in ToString method.
        /// </summary>
        /// <returns>
        /// This method returns the current cards in the deck
        /// </returns>
        public override string ToString()
        {
            string outputString = "";

            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }

            return outputString;
        }

        /// <summary>
        /// This method shuffles the deck by using random indices to select two cards at a time
        /// It uses a Fisher-Yates like algorithm
        /// </summary>
        public void Shuffle()
        {
            int firstCard;
            int secondCard;
            Card tempCard;

            for (int card = 0; card < this.Count; card++)
            {
                firstCard = this.Random.Next(0, this.Count);
                secondCard = this.Random.Next(0, this.Count);

                tempCard = (Card)this[secondCard].Clone();
                Card.OverWrite(this[secondCard], this[firstCard]);
                Card.OverWrite(this[firstCard], tempCard);
            }
        }

    }
}