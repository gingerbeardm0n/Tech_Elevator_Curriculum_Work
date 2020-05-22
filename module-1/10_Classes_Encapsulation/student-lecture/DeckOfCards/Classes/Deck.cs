using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards.Classes
{
    class Deck
    {
        private List<Card> deck = new List<Card>();

        public Deck()
        {
            string[] suits = { "Spades", "Hearts", "CLubs", "Diamonds" };

            foreach(string suit in suits)
            {
                for (int i = 1; i <= 13; i++)
                {
                    Card card = new Card(i, suit);
                    deck.Add(card);
                }
            }
        }

        public Card[] GetCards()
        {
            Card[] cards = deck.ToArray();
            return cards;
        } 
    }
}
