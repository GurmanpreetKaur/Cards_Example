﻿using System;
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
        // priavte instance variables



        //public properties


        //constructors
        // CONSTRUCTOR
        /// <summary>
        /// This is the main constructor.
        /// </summary>
        public CardList()
        {
            this._initialize();
        }


        //private methods
        protected abstract void _initialize();


        //public methods
    }
}