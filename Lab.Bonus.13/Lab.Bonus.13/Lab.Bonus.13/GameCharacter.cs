using System;
using System.Collections.Generic;
using System.Text;

namespace Lab.Bonus._13
{
    class GameCharacter
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }

      public virtual string Play()
        {
            return ($"Name: {Name}, Strength: {Strength}, Intelligence: {Intelligence}, ");
        }
    }
}
