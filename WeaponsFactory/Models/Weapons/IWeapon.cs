using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponsFactory.Models.Weapons
{
    public interface IWeapon
    {
        public string WeaponType { get; }
        public int Damage { get; }
        public string InflictDamage();
    }
}
