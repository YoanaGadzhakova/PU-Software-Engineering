using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_GameEngine
{
    public abstract class Person
    {
        
        private string name;
        private int age;

        protected Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public int Age
        {
            get { return age; }
            set 
            {
                if (value < 1)
                {
                    throw new Exception("Age should be positive number!");
                }
                age = value; 
            }
        }


        public string Name
        {
            get { return name; }
            set
            {
                if (value == null)
                {
                    throw new Exception("Name should not be null!");                   
                }
                name = value;
            }
        }

    }
}
