using System;
using System.Collections.Generic;

namespace OOP
{
    internal class Deck
    {
        private List<Card> _cards = new List<Card>();
        private Random _random = new Random();

        public int CardsCount => _cards.Count;

        public Deck()
        {
            CreateCards();
        }

        public Card GetCard()
        {
            Card card = _cards[_random.Next(0, _cards.Count)];
            _cards.Remove(card);

            return card;
        }

        private void CreateCards()
        {
            List<string> keyCard = new List<string>() { "6", "7", "8", "9", "10", "V", "Q", "K", "T" };
            List<string> suitOfCard = new List<string>() { "♥", "♦", "♣", "♠" };

            for (int i = 0; i < suitOfCard.Count; i++)
            {
                for (int j = 0; j < keyCard.Count; j++)
                {
                    Card card = new Card(suitOfCard[i], keyCard[j]);
                    _cards.Add(card);
                }
            }
        }
    }
}
