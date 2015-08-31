using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarCardGame
{
    public class Player
    {
        public Player()
        { 
        }
        public Player(string pname)
        {
            hand = new List<Card>();
            name = pname;
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private List<Card> hand;

        public List<Card> Hand
        {
            get { return hand; }
            set { hand = value; }
        }
        private int remainingCards;

        public int RemainingCards
        {
            get { return hand.Count; }
        }
        private Card flippedCard;

        public Card FlippedCard
        {
            get { return flippedCard; }
            set { flippedCard = value; }
        }
       
    }
}
