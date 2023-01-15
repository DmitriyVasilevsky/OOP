namespace OOP
{
    internal class Program
    {
        static void Main()
        {
            Player[] players = { new Player("Alex", 15, 20, 3), new Player("John", 10, 10, 1) };

            for (int i = 0; i < players.Length; i++)
            {
                players[i].ShowStats();
            }
        }
    }
}