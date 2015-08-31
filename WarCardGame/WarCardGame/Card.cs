using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WarCardGame
{
    public class Card
    {
       public Card() 
        {

        }
        public Card(string cardName, suits suit, int val)
        {
            name = cardName;
            cardSuit = suit;
            cardValue = val;
        }
        
        public enum suits { clubs, diamonds, hearts, spades, joker };
        private readonly string name;

        public string Name
        {
            get { return name; }
        }

        private int cardValue;

        public int CardValue
        {
            get { return cardValue; }
            set { cardValue = value; }
        }
        private readonly suits cardSuit;

        private suits CardSuit
        {
            get { return cardSuit; }
        }
        string backImageSource;

        public string BackImageSource
        {
            get { return backImageSource; }
            set { backImageSource = value; }
        }

       

       
        
        
    }
}
