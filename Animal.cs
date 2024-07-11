using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooControl
{
    public class Animal
    {
        private string name;
        private Food favoriteFood;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Food FavoriteFood
        {
            get { return favoriteFood; }
            set { favoriteFood = value; }
        }
        public Animal(string name, Food favoriteFood)
        {
            this.name = name;
            this.favoriteFood = favoriteFood;
        }

    }
}
