using System;
using System.Collections.Generic;
using System.Text;
using WeaponsFactory.Models.Weapons;

namespace WeaponsFactory.Models
{
    public class WeaponFactory
    {
        public static IWeapon GetWeapon(string weaponType)
        {
            IWeapon weapon = null;

            switch (weaponType.ToLower())
            {
                case "bow":
                    weapon = new Bow();
                    break;
                case "gun":
                    weapon = new Gun();
                    break;
                case "knife":
                    weapon = new Knife();
                    break;
                default:
                    throw new ArgumentException("Invalid weapon type!");
                    break;
            }
            return weapon;
        }
    }
}
