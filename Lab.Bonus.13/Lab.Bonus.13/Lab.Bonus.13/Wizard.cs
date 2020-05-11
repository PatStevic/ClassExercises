using System;
using System.Collections.Generic;
using System.Text;

namespace Lab.Bonus._13
{
    class Wizard : MagicUsingCharacter 
    {
        public int SpellNumber { get; set; }

        public override string Play()
        {
            return base.Play() + ($" Weapon Type: {SpellNumber}");
        }
    }
}
