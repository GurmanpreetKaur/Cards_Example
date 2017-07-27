using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Gurmanpreet Kaur
 * Date: July 27, 2017
 * Description: This is the Card Class
 * Version: 0.3 - Added the OverWrite method
 */
namespace Cards_Example
{
    public class Card : ICloneable
    {
        // PRIVATE INSTANCE VARIABLES
        private Face _face;
        private Suit _suit;

        // PUBLIC PROPERTIES
        public Face Face
        {

            get
            {
                return this._face;
            }

            set
            {
                this._face = value;
            }
        }

        public Suit Suit
        {

            get
            {
                return this._suit;
            }


            set
            {
                this._suit = value;
            }

        }

        // CONSTRUCTORS

        /// <summary>
        /// This is the main constructor.
        /// It takes two parameters - face (Face) - suit (Suit)
        /// </summary>
        /// <param name="face"></param>
        /// <param name="suit"></param>
        public Card(Face face, Suit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }


        // PRIVATE METHODS

        // PUBLIC METHODS
        /// <summary>
        /// This method overrides the built-in Clone method.
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new Card(this.Face, this.Suit);
        }


        /// <summary>
        /// This method overwrites the first card with the second card
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        public static void OverWrite(Card first, Card second)
        {
            first.Face = second.Face;
            first.Suit = second.Suit;
        }
    }
}