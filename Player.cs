namespace OOP
{
    internal class Player
    {
        public int PositionX { get; private set; }

        public int PositionY { get; private set; }

        public Player(int positionX, int positionY)
        {
            PositionX = positionX;
            PositionY = positionY;
        }
    }
}