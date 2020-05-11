using System;
using System.Collections.Generic;
using System.Text;

namespace Lab.Bonus._13
{
    class MagicUsingCharacter : GameCharacter
    {
        public int MagicalEnergy { get; set; }

        public override string Play()
        {
            return base.Play() + ($"Weapon Type: {MagicalEnergy}");
        }
    }
}
