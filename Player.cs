using System;

namespace OOP
{
    internal class Player
    {
        private string _name;
        private int _strength;
        private int _agility;
        private int _level;

        public Player(string name, int strength, int agility, int level)
        {
            _name = name;
            _strength = strength;
            _agility = agility;
            _level = level;
        }

        public void ShowStats()
        {
            Console.WriteLine("Характеристики игрока " + _name + ":\n" +
                              "Сила - " + _strength + ";\n" +
                              "Ловкость - " + _agility + ";\n" +
                              "Уровень - " + _level + ";\n");
        }
    }
}