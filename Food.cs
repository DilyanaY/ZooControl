﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooControl
{
    public class Food
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Food(string name)
        {
            this.name = name;
        }

    }
}
