using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarCardGame
{
    public class WarGame
    {
        public WarGame()
        {
            cardDeck = new Deck(Deck.CardBackStyle.standard);
            player1 = new Player("player1");
            player2 = new Player("player2");
            cardsInPlay = new List<Card>();
            tieHandCount = 0;
            playerMadeMove = false;
        }
        public WarGame(Deck.CardBackStyle style, string pName1, string pName2)
        {
            cardDeck = new Deck(style);
            player1 = new Player(pName1);
            player2 = new Player(pName2);
            cardsInPlay = new List<Card>();
            tieHandCount = 0;
            playerMadeMove = false;
        }

        private Deck cardDeck;

        public Deck CardDeck
        {
            get { return cardDeck; }
        }
        private Player player1;

        public Player Player1
        {
            get { return player1; }
          //  set { player1 = value; }
        }
        private Player player2;

        public Player Player2
        {
            get { return player2; }
            //set { player2 = value; }
        }
        private List<Card> cardsInPlay;

        public List<Card> CardsInPlay
        {
            get { return cardsInPlay; }
            set { cardsInPlay = value; }
        }
        private int tieHandCount;

        public int TieHandCount
        {
          get { return tieHandCount; }
          set { tieHandCount = value; }
        }
        private bool playerMadeMove;
        private string winningPlayer;

        public string WinningPlayer
        {
            get { return winningPlayer; }
            set { winningPlayer = value; }
        }
        
        public void PlayCards(Player player)
        {
            
            int numberCardsToPlay = tieHandCount + 1;
            if (numberCardsToPlay > player.Hand.Count)
            {
                //change number of cards played if player doensn't have enough cards
                numberCardsToPlay = player.Hand.Count;
            }
            for (int i = 0; i < numberCardsToPlay; i++)
            {
                //remove cards from players hand and put them in play
                cardsInPlay.Add(player.Hand[i]);
                player.Hand.RemoveAt(i);
            }
            player.FlippedCard = cardsInPlay[cardsInPlay.Count-1];
            player.Hand.TrimExcess();

            if (playerMadeMove == false)
            {
                playerMadeMove = true;
            }
            else
            {
                FindWinner();
                playerMadeMove = false;
               
            }
        }

        private void FindWinner()
        {
            if (player1.FlippedCard.CardValue == player2.FlippedCard.CardValue)
            { 
                //tie
                winningPlayer = "WAR";
                tieHandCount += 1;
            }
            else if(player1.FlippedCard.CardValue > player2.FlippedCard.CardValue )
            {
                SetHandWinner(player1);
            }
            else  
            {
                SetHandWinner(player2);
            }

        }
        public void Deal()
        {
            List<Card> hand1;
            List<Card> hand2;
            CardDeck.Deal(27, out hand1, out hand2);
            player1.Hand = hand1;
            player2.Hand = hand2;
        }
        private void SetHandWinner(Player player)
        {
            winningPlayer = player.Name;
            for (int i = 0; i < cardsInPlay.Count; i++)
            {
                player.Hand.Add(cardsInPlay[i]);
            }
            TieHandCount = 0;
            CardsInPlay = new List<Card>();
            
        }
                
    }
}
