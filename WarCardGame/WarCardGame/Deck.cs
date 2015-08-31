using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.Generic;

namespace WarCardGame
{   //TODO Find the correct naming convention for Class libray
    public class Deck
    {
        public Deck()
        {
            cardDeck = new List<Card>();
            InitializeDeck();   
        }
        public Deck(CardBackStyle style)
        {
            cardStyleBack = style;
            cardDeck = new List<Card>();
            InitializeDeck();
        }
        
        public enum CardBackStyle {standard, ocean};
        public enum CardFrontStyle {black, blue, green, orange, purple, red };

        private CardBackStyle cardStyleBack;

        public CardBackStyle CardStyleBack
        {
            get { return cardStyleBack; }
            set { cardStyleBack = value; }
        }

        private List<Card> cardDeck;

        public List<Card> CardDeck
        {
            get { return cardDeck; }
           
        }
        
        private Card twoOfDiamonds;
        private Card threeOfDiamonds;
        private Card fourOfDiamonds;
        private Card fiveOfDiamonds;
        private Card sixOfDiamonds;
        private Card sevenOfDiamonds;
        private Card eightOfDiamonds;
        private Card nineOfDiamonds;
        private Card tenOfDiamonds;
        private Card jackOfdiamonds;
        private Card queenOfDiamonds;
        private Card kingOfDiamonds;
        private Card aceOfDiamonds;
        private Card twoOfHearts;
        private Card threeOfHearts;
        private Card fourOfHearts;
        private Card fiveOfHearts;
        private Card sixOfHearts;
        private Card sevenOfHearts;
        private Card eightOfHearts;
        private Card nineOfHearts;
        private Card tenOfHearts;
        private Card jackOfHearts;
        private Card queenOfHearts;
        private Card kingOfHearts;
        private Card aceOfHearts;
        private Card twoOfClubs;
        private Card threeOfClubs;
        private Card fourOfClubs;
        private Card fiveOfClubs;
        private Card sixOfClubs;
        private Card sevenOfClubs;
        private Card eightOfClubs;
        private Card nineOfClubs;
        private Card tenOfClubs;
        private Card jackOfClubs;
        private Card queenOfClubs;
        private Card kingOfClubs;
        private Card aceOfClubs;
        private Card twoOfSpades;
        private Card threeOfSpades;
        private Card fourOfSpades;
        private Card fiveOfSpades;
        private Card sixOfSpades;
        private Card sevenOfSpades;
        private Card eightOfSpades;
        private Card nineOfSpades;
        private Card tenOfSpades;
        private Card jackOfSpades;
        private Card queenOfSpades;
        private Card kingOfSpades;
        private Card aceOfSpades;
        private Card jokerBlack;
        private Card jokerRed;
        
        public void Shuffle()
        {
            //use Fisher–Yates shuffle to shuffle deck
            int timesToShuffle = 10;
            Random rand = new Random();
            for (int i = 0; i < cardDeck.Count * timesToShuffle; i += 2)
            {
                //generate random cards to swap
                int randomCardLoc1 = rand.Next(cardDeck.Count);
                int randomCardLoc2 = rand.Next(cardDeck.Count);
                //swap cards
                Card tempCard = cardDeck[randomCardLoc1];
                cardDeck[randomCardLoc1] = cardDeck[randomCardLoc2];
                cardDeck[randomCardLoc2] = tempCard;
            }
        }
        public void Deal(int numCardsPerPlayer, out List<Card> player1Deck, out List<Card> player2Deck )
        {
            //Deal deck to players
            player1Deck = new List<Card>();
            player2Deck = new List<Card>();
            Shuffle();
            for (int i = 0; i < numCardsPerPlayer*2 - 1; i++)
            {
                player1Deck.Add(cardDeck[i]);
                i++;
                player2Deck.Add(cardDeck[i]);
            }
            
        }
        
        private void InitializeDeck()
        {   //create cards
            twoOfDiamonds = new Card("Two Of Diamonds", Card.suits.diamonds, 2);
            threeOfDiamonds = new Card("Three Of Diamonds", Card.suits.diamonds, 3);
            fourOfDiamonds = new Card("Four Of Diamonds", Card.suits.diamonds, 4);
            fiveOfDiamonds = new Card("Five Of Diamonds", Card.suits.diamonds, 5);
            sixOfDiamonds = new Card("Six Of Diamonds", Card.suits.diamonds, 6);
            sevenOfDiamonds = new Card("Seven of Diamonds", Card.suits.diamonds, 7);
            eightOfDiamonds = new Card("Eight of Diamonds", Card.suits.diamonds, 8);
            nineOfDiamonds = new Card("Nine of Diamonds", Card.suits.diamonds, 9);
            tenOfDiamonds = new Card("Ten of Diamonds", Card.suits.diamonds, 10);
            jackOfdiamonds = new Card("Jack of Diamonds", Card.suits.diamonds, 11);
            queenOfDiamonds = new Card("Queen of Diamonds", Card.suits.diamonds, 12);
            kingOfDiamonds = new Card("King of Diamonds", Card.suits.diamonds, 13);
            aceOfDiamonds = new Card("Ace Of Diamonds", Card.suits.diamonds, 14);
            twoOfHearts = new Card("Two of Hearts", Card.suits.hearts, 2);
            threeOfHearts = new Card("Three of Hearts", Card.suits.hearts, 3);
            fourOfHearts = new Card("Four of Hearts", Card.suits.hearts, 4);
            fiveOfHearts = new Card("Five of Hearts", Card.suits.hearts, 5);
            sixOfHearts = new Card("Six of Hearts", Card.suits.hearts, 6);
            sevenOfHearts = new Card("Seven of Hearts", Card.suits.hearts, 7);
            eightOfHearts = new Card("Eight of Hearts", Card.suits.hearts, 8);
            nineOfHearts = new Card("Nine of Hearts", Card.suits.hearts, 9);
            tenOfHearts = new Card("Ten of Hearts", Card.suits.hearts, 10);
            jackOfHearts = new Card("Jack of Hearts", Card.suits.hearts, 11);
            queenOfHearts = new Card("Queen of Hearts", Card.suits.hearts, 12);
            kingOfHearts = new Card("King of Hearts", Card.suits.hearts, 13);
            aceOfHearts = new Card("Ace of Hearts", Card.suits.hearts, 14);
            twoOfClubs = new Card("Two of Clubs", Card.suits.clubs, 2);
            threeOfClubs = new Card("Three of Clubs", Card.suits.clubs, 3);
            fourOfClubs = new Card("Four of Clubs", Card.suits.clubs, 4);
            fiveOfClubs = new Card("Five of Clubs", Card.suits.clubs, 5);
            sixOfClubs = new Card("Six of Clubs", Card.suits.clubs, 6);
            sevenOfClubs = new Card("Seven of Clubs", Card.suits.clubs, 7);
            eightOfClubs = new Card("Eight of Clubs", Card.suits.clubs, 8);
            nineOfClubs = new Card("Nine of Clubs", Card.suits.clubs, 9);
            tenOfClubs = new Card("Ten of Clubs", Card.suits.clubs, 10);
            jackOfClubs = new Card("Jack of Clubs", Card.suits.clubs, 11);
            queenOfClubs = new Card("Queen of Clubs", Card.suits.clubs, 12);
            kingOfClubs = new Card("King of Clubs", Card.suits.clubs, 13);
            aceOfClubs = new Card("Ace of Clubs", Card.suits.clubs, 14);
            twoOfSpades = new Card("Two of Spades", Card.suits.spades, 2);
            threeOfSpades = new Card("Three of Spades", Card.suits.spades, 3);
            fourOfSpades = new Card("Four of Spades", Card.suits.spades, 4);
            fiveOfSpades = new Card("Five of Spades", Card.suits.spades, 5);
            sixOfSpades = new Card("Six of Spades", Card.suits.spades, 6);
            sevenOfSpades = new Card("Seven of Spades", Card.suits.spades, 7);
            eightOfSpades = new Card("Eight of Spades", Card.suits.spades, 8);
            nineOfSpades = new Card("Nine of Spades", Card.suits.spades, 9);
            tenOfSpades = new Card("Ten of Spades", Card.suits.spades, 10);
            jackOfSpades = new Card("Jack of Spades", Card.suits.spades, 11);
            queenOfSpades = new Card("Queen of Spades", Card.suits.spades, 12);
            kingOfSpades = new Card("King of Spades", Card.suits.spades, 13);
            aceOfSpades = new Card("Ace of Spades", Card.suits.spades, 14);
            jokerBlack = new Card("Black Joker", Card.suits.joker, 15);
            jokerRed = new Card("Red Joker", Card.suits.joker, 15);
            //choose card back style
            switch (cardStyleBack)
            {
                case CardBackStyle.standard:
                    
                    InitializeStandardDeckStyle();
                    break;
                case CardBackStyle.ocean:
                    InitializeOceanDeckStyle();
                    break;
                default:
                    break;
            }
            AddCardsToDeck();
        }

        private void InitializeOceanDeckStyle()
        {
            twoOfDiamonds.BackImageSource = "Resources/CardDecks/Ocean/02d.gif";
            threeOfDiamonds.BackImageSource = "Resources/CardDecks/Ocean/03d.gif";
            fourOfDiamonds.BackImageSource = "Resources/CardDecks/Ocean/04d.gif";
            fiveOfDiamonds.BackImageSource = "Resources/CardDecks/Ocean/05d.gif";
            sixOfDiamonds.BackImageSource = "Resources/CardDecks/Ocean/06d.gif";
            sevenOfDiamonds.BackImageSource = "Resources/CardDecks/Ocean/07d.gif";
            eightOfDiamonds.BackImageSource = "Resources/CardDecks/Ocean/08d.gif";
            nineOfDiamonds.BackImageSource = "Resources/CardDecks/Ocean/09d.gif";
            tenOfDiamonds.BackImageSource = "Resources/CardDecks/Ocean/10d.gif";
            jackOfdiamonds.BackImageSource = "Resources/CardDecks/Ocean/11d.gif"; ;
            queenOfDiamonds.BackImageSource = "Resources/CardDecks/Ocean/12d.gif";
            kingOfDiamonds.BackImageSource = "Resources/CardDecks/Ocean/13d.gif";
            aceOfDiamonds.BackImageSource = "Resources/CardDecks/Ocean/01d.gif";
            twoOfHearts.BackImageSource = "Resources/CardDecks/Ocean/02h.gif";
            threeOfHearts.BackImageSource = "Resources/CardDecks/Ocean/03h.gif";
            fourOfHearts.BackImageSource = "Resources/CardDecks/Ocean/04h.gif";
            fiveOfHearts.BackImageSource = "Resources/CardDecks/Ocean/05h.gif";
            sixOfHearts.BackImageSource = "Resources/CardDecks/Ocean/06h.gif";
            sevenOfHearts.BackImageSource = "Resources/CardDecks/Ocean/07h.gif";
            eightOfHearts.BackImageSource = "Resources/CardDecks/Ocean/08h.gif";
            nineOfHearts.BackImageSource = "Resources/CardDecks/Ocean/09h.gif";
            tenOfHearts.BackImageSource = "Resources/CardDecks/Ocean/10h.gif";
            jackOfHearts.BackImageSource = "Resources/CardDecks/Ocean/11h.gif"; ;
            queenOfHearts.BackImageSource = "Resources/CardDecks/Ocean/12h.gif";
            kingOfHearts.BackImageSource = "Resources/CardDecks/Ocean/13h.gif";
            aceOfHearts.BackImageSource = "Resources/CardDecks/Ocean/01h.gif";
            twoOfClubs.BackImageSource = "Resources/CardDecks/Ocean/02c.gif";
            threeOfClubs.BackImageSource = "Resources/CardDecks/Ocean/03c.gif";
            fourOfClubs.BackImageSource = "Resources/CardDecks/Ocean/04c.gif";
            fiveOfClubs.BackImageSource = "Resources/CardDecks/Ocean/05c.gif";
            sixOfClubs.BackImageSource = "Resources/CardDecks/Ocean/06c.gif";
            sevenOfClubs.BackImageSource = "Resources/CardDecks/Ocean/07c.gif";
            eightOfClubs.BackImageSource = "Resources/CardDecks/Ocean/08c.gif";
            nineOfClubs.BackImageSource = "Resources/CardDecks/Ocean/09c.gif";
            tenOfClubs.BackImageSource = "Resources/CardDecks/Ocean/10c.gif";
            jackOfClubs.BackImageSource = "Resources/CardDecks/Ocean/11c.gif";
            queenOfClubs.BackImageSource = "Resources/CardDecks/Ocean/12c.gif";
            kingOfClubs.BackImageSource = "Resources/CardDecks/Ocean/13c.gif";
            aceOfClubs.BackImageSource = "Resources/CardDecks/Ocean/01c.gif";
            twoOfSpades.BackImageSource = "Resources/CardDecks/Ocean/02s.gif";
            threeOfSpades.BackImageSource = "Resources/CardDecks/Ocean/03s.gif";
            fourOfSpades.BackImageSource = "Resources/CardDecks/Ocean/04s.gif";
            fiveOfSpades.BackImageSource = "Resources/CardDecks/Ocean/05s.gif";
            sixOfSpades.BackImageSource = "Resources/CardDecks/Ocean/06s.gif";
            sevenOfSpades.BackImageSource = "Resources/CardDecks/Ocean/07s.gif";
            eightOfSpades.BackImageSource = "Resources/CardDecks/Ocean/08s.gif";
            nineOfSpades.BackImageSource = "Resources/CardDecks/Ocean/09s.gif";
            tenOfSpades.BackImageSource = "Resources/CardDecks/Ocean/10s.gif";
            jackOfSpades.BackImageSource = "Resources/CardDecks/Ocean/11s.gif";
            queenOfSpades.BackImageSource = "Resources/CardDecks/Ocean/12s.gif";
            kingOfSpades.BackImageSource = "Resources/CardDecks/Ocean/13s.gif";
            aceOfSpades.BackImageSource = "Resources/CardDecks/Ocean/01s.gif";
            jokerBlack.BackImageSource = "Resources/CardDecks/StandardDeck/black_joker.png";
            jokerRed.BackImageSource = "Resources/CardDecks/StandardDeck/red_joker.png"; 
        }
        private void InitializeStandardDeckStyle()
        {
           //set the backcard images to standard deck images
             twoOfDiamonds.BackImageSource = "Resources/CardDecks/StandardDeck/2_of_diamonds.png";
             threeOfDiamonds.BackImageSource = "Resources/CardDecks/StandardDeck/3_of_diamonds.png";
             fourOfDiamonds.BackImageSource = "Resources/CardDecks/StandardDeck/4_of_diamonds.png";
             fiveOfDiamonds.BackImageSource = "Resources/CardDecks/StandardDeck/5_of_diamonds.png";
             sixOfDiamonds.BackImageSource = "Resources/CardDecks/StandardDeck/6_of_diamonds.png";
             sevenOfDiamonds.BackImageSource = "Resources/CardDecks/StandardDeck/7_of_diamonds.png";
             eightOfDiamonds.BackImageSource = "Resources/CardDecks/StandardDeck/8_of_diamonds.png";
             nineOfDiamonds.BackImageSource = "Resources/CardDecks/StandardDeck/9_of_diamonds.png";
             tenOfDiamonds.BackImageSource = "Resources/CardDecks/StandardDeck/10_of_diamonds.png";
             jackOfdiamonds.BackImageSource = "Resources/CardDecks/StandardDeck/jack_of_diamonds.png";
             queenOfDiamonds.BackImageSource = "Resources/CardDecks/StandardDeck/queen_of_diamonds.png";
             kingOfDiamonds.BackImageSource = "Resources/CardDecks/StandardDeck/king_of_diamonds.png";
             aceOfDiamonds.BackImageSource = "Resources/CardDecks/StandardDeck/ace_of_diamonds.png";
             twoOfHearts.BackImageSource = "Resources/CardDecks/StandardDeck/2_of_hearts.png";
             threeOfHearts.BackImageSource = "Resources/CardDecks/StandardDeck/3_of_hearts.png";
             fourOfHearts.BackImageSource = "Resources/CardDecks/StandardDeck/4_of_hearts.png";
             fiveOfHearts.BackImageSource = "Resources/CardDecks/StandardDeck/5_of_hearts.png";
             sixOfHearts.BackImageSource = "Resources/CardDecks/StandardDeck/6_of_hearts.png";
             sevenOfHearts.BackImageSource = "Resources/CardDecks/StandardDeck/7_of_hearts.png";
             eightOfHearts.BackImageSource = "Resources/CardDecks/StandardDeck/8_of_hearts.png";
             nineOfHearts.BackImageSource = "Resources/CardDecks/StandardDeck/9_of_hearts.png";
             tenOfHearts.BackImageSource = "Resources/CardDecks/StandardDeck/10_of_hearts.png";
             jackOfHearts.BackImageSource = "Resources/CardDecks/StandardDeck/jack_of_hearts.png";
             queenOfHearts.BackImageSource = "Resources/CardDecks/StandardDeck/queen_of_hearts.png";
             kingOfHearts.BackImageSource = "Resources/CardDecks/StandardDeck/king_of_hearts.png";
             aceOfHearts.BackImageSource = "Resources/CardDecks/StandardDeck/ace_of_hearts.png";
             twoOfClubs.BackImageSource = "Resources/CardDecks/StandardDeck/2_of_clubs.png";
             threeOfClubs.BackImageSource = "Resources/CardDecks/StandardDeck/3_of_clubs.png";
              fourOfClubs.BackImageSource = "Resources/CardDecks/StandardDeck/4_of_clubs.png";
              fiveOfClubs.BackImageSource = "Resources/CardDecks/StandardDeck/5_of_clubs.png";
              sixOfClubs.BackImageSource = "Resources/CardDecks/StandardDeck/6_of_clubs.png";
              sevenOfClubs.BackImageSource = "Resources/CardDecks/StandardDeck/7_of_clubs.png";
              eightOfClubs.BackImageSource = "Resources/CardDecks/StandardDeck/8_of_clubs.png";
              nineOfClubs.BackImageSource = "Resources/CardDecks/StandardDeck/9_of_clubs.png";
              tenOfClubs.BackImageSource = "Resources/CardDecks/StandardDeck/10_of_clubs.png";
              jackOfClubs.BackImageSource = "Resources/CardDecks/StandardDeck/jack_of_clubs.png";
              queenOfClubs.BackImageSource = "Resources/CardDecks/StandardDeck/queen_of_clubs.png";
              kingOfClubs.BackImageSource = "Resources/CardDecks/StandardDeck/king_of_clubs.png";
              aceOfClubs.BackImageSource = "Resources/CardDecks/StandardDeck/ace_of_clubs.png";
              twoOfSpades.BackImageSource = "Resources/CardDecks/StandardDeck/2_of_spades.png";
              threeOfSpades.BackImageSource = "Resources/CardDecks/StandardDeck/3_of_spades.png";
              fourOfSpades.BackImageSource = "Resources/CardDecks/StandardDeck/4_of_spades.png";
              fiveOfSpades.BackImageSource = "Resources/CardDecks/StandardDeck/5_of_spades.png";
              sixOfSpades.BackImageSource = "Resources/CardDecks/StandardDeck/6_of_spades.png";
              sevenOfSpades.BackImageSource = "Resources/CardDecks/StandardDeck/7_of_spades.png";
              eightOfSpades.BackImageSource = "Resources/CardDecks/StandardDeck/8_of_spades.png";
              nineOfSpades.BackImageSource = "Resources/CardDecks/StandardDeck/9_of_spades.png";
              tenOfSpades.BackImageSource = "Resources/CardDecks/StandardDeck/10_of_spades.png";
              jackOfSpades.BackImageSource = "Resources/CardDecks/StandardDeck/jack_of_spades.png";
              queenOfSpades.BackImageSource = "Resources/CardDecks/StandardDeck/queen_of_spades.png";
              kingOfSpades.BackImageSource = "Resources/CardDecks/StandardDeck/king_of_spades.png";
              aceOfSpades.BackImageSource = "Resources/CardDecks/StandardDeck/ace_of_spades.png";
              jokerBlack.BackImageSource = "Resources/CardDecks/StandardDeck/black_joker.png";
              jokerRed.BackImageSource = "Resources/CardDecks/StandardDeck/red_joker.png"; 
        }
        private void AddCardsToDeck()
        {   //add Cards to deck
            cardDeck.Add(twoOfDiamonds);
            cardDeck.Add(threeOfDiamonds);
             cardDeck.Add(fourOfDiamonds);
             cardDeck.Add(fiveOfDiamonds);
             cardDeck.Add(sixOfDiamonds);
             cardDeck.Add(sevenOfDiamonds);
             cardDeck.Add(eightOfDiamonds);
             cardDeck.Add(nineOfDiamonds);
             cardDeck.Add(tenOfDiamonds);
             cardDeck.Add(jackOfdiamonds);
             cardDeck.Add(queenOfDiamonds);
             cardDeck.Add(kingOfDiamonds);
             cardDeck.Add(aceOfDiamonds);
             cardDeck.Add(twoOfHearts);
             cardDeck.Add(threeOfHearts);
             cardDeck.Add(fourOfHearts);
             cardDeck.Add(fiveOfHearts);
             cardDeck.Add(sixOfHearts);
             cardDeck.Add(sevenOfHearts);
             cardDeck.Add(eightOfHearts);
             cardDeck.Add(nineOfHearts);
             cardDeck.Add(tenOfHearts);
             cardDeck.Add(jackOfHearts);
             cardDeck.Add(queenOfHearts);
             cardDeck.Add(kingOfHearts);
             cardDeck.Add(aceOfHearts);
             cardDeck.Add(twoOfClubs);
             cardDeck.Add(threeOfClubs);
             cardDeck.Add(fourOfClubs);
             cardDeck.Add(fiveOfClubs);
             cardDeck.Add(sixOfClubs);
             cardDeck.Add(sevenOfClubs);
             cardDeck.Add(eightOfClubs);
             cardDeck.Add(nineOfClubs);
             cardDeck.Add(tenOfClubs);
             cardDeck.Add(jackOfClubs);
             cardDeck.Add(queenOfClubs);
             cardDeck.Add(kingOfClubs);
             cardDeck.Add(aceOfClubs);
             cardDeck.Add(twoOfSpades);
             cardDeck.Add(threeOfSpades);
             cardDeck.Add(fourOfSpades);
             cardDeck.Add(fiveOfSpades);
             cardDeck.Add(sixOfSpades);
             cardDeck.Add(sevenOfSpades);
             cardDeck.Add(eightOfSpades);
             cardDeck.Add(nineOfSpades);
             cardDeck.Add(tenOfSpades);
             cardDeck.Add(jackOfSpades);
             cardDeck.Add(queenOfSpades);
             cardDeck.Add(kingOfSpades);
             cardDeck.Add(aceOfSpades);
             cardDeck.Add(jokerBlack);
             cardDeck.Add(jokerRed);
        }
    }
}
