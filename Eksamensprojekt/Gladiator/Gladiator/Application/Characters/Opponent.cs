using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiator.Application.Characters
{
    public class Opponent : Character
    {
        public string Name { get; set; }

        public Opponent(string name)
        {
            Name = name;
        }
    }
}
