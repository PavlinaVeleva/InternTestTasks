using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponsFactory.Models.Weapons
{
    public class Knife : IWeapon
    {
        public string WeaponType => nameof(Knife);

        public int Damage => 10;

        public string InflictDamage()
        {
            return String.Format("{0} stabs for {1} damage!", WeaponType, Damage);
        }
    }
}
