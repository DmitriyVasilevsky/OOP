using System;

namespace OOP
{
    internal class Renderer
    {
        public void DrawPlayer(int PositionX, int PositionY, char player = '@')
        {
            Console.SetCursorPosition(PositionX, PositionY);
            Console.Write(player);
        }
    }
}