using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Gurmanpreet Kaur
 * Date: July 27, 2017
 * Description: This is Abstract superclass Card lIST
 * Version: 0.3 - CREATED the cardlist class
 */
namespace Cards_Example
{
    public abstract class CardList : List<Card>
    {
        // PRIVATE INSTANCE VARIABLES

        // PUBLIC PROPERTIES

        // CONSTRUCTORS

        /// <summary>
        /// This is the main constructor.
        /// </summary>
        public CardList()
        {
            this._initialize();
        }

        // PRIVATE METHODS
        protected abstract void _initialize();

        // PUBLIC METHODS


        
    }
}