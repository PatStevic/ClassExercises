using System;
using System.Collections.Generic;
using System.Text;

namespace Lab.Bonus._13
{
    class Warrior : GameCharacter
    {
        public string WeaponType { get; set; }

        public override string Play()
        {
            return base.Play()+($"Weapon Type: {WeaponType}");
        }
    }
}
