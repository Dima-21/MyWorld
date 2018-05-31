using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorld
{
    class World
    {
        public int Human { get; set; }
        public int Warriors { get; set; }
        public int Money { get; set; }
        public World()
        {
            Human = 1000;
            Warriors = 50;
            Money = 8000;
        }
    }
}
