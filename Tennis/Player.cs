using System;
using System.Collections.Generic;
using System.Text;

namespace Tennis
{
    public class Player
    {
        public int Score { get; private set; }
        public string Name { get; private set; }

        public Player(string name)
        {
            Name = name;
            Score = 0;
        }

        public void AddPoint()
        {
            Score += 1;
        }
    }
}
