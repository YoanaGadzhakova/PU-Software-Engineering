using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_GameEngine
{
    public abstract class FootballPlayer : Person
    {
        protected FootballPlayer(string name, int age, int number, double height)
            : base(name, age)
        {
            Number = number;
            this.Height = height;
        }

        public int Number { get; set; }
        private double height;

        public double Height
        {
            get { return height; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Height should be positive number!");
                }
                height = value;
            }
        }

    }
}
