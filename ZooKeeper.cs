using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooControl
{
    public class ZooKeeper
    {
        private string firstName;
        private string lastName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public ZooKeeper(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void FeedAnimal(Animal animal)
        {
            Console.WriteLine($"{FirstName} {LastName} храни {animal.Name} с/със {animal.FavoriteFood.Name}");
        }

    }
}
