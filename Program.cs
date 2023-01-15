using System;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string CommandGetOneCard = "1";
            string CommandGetCards = "2";
            string CommandEnoughCards = "3";
            string CommandEndProgram = "4";
            bool isWorking = true;

            Deck deck = new Deck();
            Player player = new Player();

            while (isWorking)
            {
                player.ShowRules();

                Console.SetCursorPosition(0, 9);
                Console.WriteLine(CommandGetOneCard + " - получить 1 карту.");
                Console.WriteLine(CommandGetCards + " - получить несколько карт.");
                Console.WriteLine(CommandEnoughCards + " - посмотреть.");
                Console.WriteLine(CommandEndProgram + " - выйти из игры.");
                Console.WriteLine("Карт в колоде: " + deck.CardsCount);


                Console.SetCursorPosition(0, 15);
                Console.Write("Ввод: ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        player.TakeCard(deck);
                        Console.ReadKey();
                        break;
                    case "2":
                        player.TakeSeveralCards(deck);
                        Console.ReadKey();
                        break;
                    case "3":
                        player.ShowReceivedCards();
                        break;
                    case "4":
                        isWorking = false;
                        break;
                    default:
                        Console.WriteLine("Такой команды нет.");
                        Console.ReadKey();
                        break;
                }

                Console.Clear();
            }
        }
    }
}
