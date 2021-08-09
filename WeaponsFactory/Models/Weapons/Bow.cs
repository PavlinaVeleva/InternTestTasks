using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponsFactory.Models.Weapons
{
    class Bow : IWeapon
    {
        public string WeaponType => nameof(Bow);

        public int Damage => 15;

        public string InflictDamage()
        {
            return String.Format("{0} shoots for {1} damage!", WeaponType, Damage);
        }
    }
}
