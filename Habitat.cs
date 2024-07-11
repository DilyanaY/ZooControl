using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooControl
{
    public class Habitat
    {
        private string name;
        private List<Animal> animals;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public List<Animal> Animals
        {
            get { return animals; }
            set { animals = value; }
        }
        public Habitat(string name)
        {
            this.name = name;
            animals = new List<Animal>();
        }

    }
}
