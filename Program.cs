namespace OOP
{
    internal class Program
    {
        static void Main()
        {
            Renderer renderer = new Renderer();
            Player player = new Player(5, 10);

            renderer.DrawPlayer(player.PositionX, player.PositionY);
        }
    }
}