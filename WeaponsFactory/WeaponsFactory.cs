using System;
using WeaponsFactory.Models;
using WeaponsFactory.Models.Weapons;

namespace WeaponsFactory
{
    class WeaponsFactory
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the type of the weapon you would like to instantiated: ");
            string weaponType = Console.ReadLine();

            IWeapon weapon = WeaponFactory.GetWeapon(weaponType);
            Console.WriteLine(weapon.InflictDamage());
        }
    }
}
