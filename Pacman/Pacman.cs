using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public class Pacman
    {
        public int Points { get; set; }
        public int Lives { get; set; }
        public int Bonus { get; set; }

        public Pacman()
        {
            Points = 5000;
            Lives = 3;
            Bonus = 0;
        }
    }
}
