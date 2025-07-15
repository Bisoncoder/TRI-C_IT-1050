using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This file is part of the Practice_OOP project, but it's been separated into its own file for better organization. 
namespace Practice_OOP
{
    internal class food
    {
        //`Name` and `Weight` are the same properties as in the original code, which can be accessed from outside the class. Because of this, their availability does not need to be declared again.
        string name;
        int weight;
        public int size;
        private string taste;
        private bool edible;

        public food(string name, int weight, int size, string taste)
        {
            this.name = name;
            this.weight = weight;
            this.size = size;
            this.taste = taste;
        }
    }
}
