namespace OOP
{
    internal class Player
    {
        private int _positionX;
        private int _positionY;

        public int PositionX
        {
            get
            {
                return _positionX;
            }
            private set
            {
                _positionX = value;
            }
        }

        public int PositionY
        {
            get
            {
                return _positionY;
            }
            private set
            {
                _positionY = value;
            }
        }

        public Player(int PositionX, int PositionY)
        {
            _positionX = PositionX;
            _positionY = PositionY;
        }
    }
}
