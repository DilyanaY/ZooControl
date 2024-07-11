using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooControl
{
    public class Zoo
    {
        private List<Habitat> habitats;
        public List<Habitat> Habitats
        {
            get { return habitats; }
            set { habitats = value; }
        }

        public Zoo()
        {
            habitats = new List<Habitat>();
        }

    }
}
