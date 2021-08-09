using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponsFactory.Models.Weapons
{
    public class Gun : IWeapon
    {
        public string WeaponType => nameof(Gun);

        public int Damage => 20;

        public string InflictDamage()
        {
            return String.Format("{0} shoots for {1} damage!", WeaponType, Damage);
        }
    }
}
