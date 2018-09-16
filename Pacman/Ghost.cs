using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public class Ghost
    {
        public bool IsVulnerable { get; set; }
        public int Bonus { get; set; } = 200;

        public void MultipleBonus()
        {
            Bonus *= 2;
        }
    }
}
