using System;
using System.Collections.Generic;

namespace OOP
{
    internal class Player
    {
        private List<Card> _cards = new List<Card>();

        public void TakeCard(Deck deck)
        {
            if (deck.CardsCount > 0)
            {
                _cards.Add(deck.GetCard());
            }
            else
            {
                Console.WriteLine("Ошибка.");
            }
        }

        public void TakeSeveralCards(Deck deck)
        {
            Console.Write("Сколько карт хотите получить:");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int result) == true && result <= deck.CardsCount && result >= 0)
            {
                for (int i = 0; i < result; i++)
                {
                    TakeCard(deck);
                }
            }
            else
            {
                Console.WriteLine("Ошибка.");
            }
        }

        public void ShowReceivedCards()
        {
            Console.WriteLine($"Ваше количество карт на руках - {_cards.Count}");

            foreach (var card in _cards)
            {
                Console.Write(card.GetInfo() + " | ");
            }

            Console.ReadKey();
        }

        public void ShowRules()
        {
            Console.WriteLine("Играем в очко!\n" +
                              "В нашей колоде 36 карт.\n" +
                              "Цель: максимально приблизиться к 21.\n");
            Console.WriteLine("V - валет (ценность: 2)\n" +
                              "Q - королева (ценность: 3)\n" +
                              "K - король (ценность: 4)\n" +
                              "T - туз (ценность: 5)");
        }
    }
}
