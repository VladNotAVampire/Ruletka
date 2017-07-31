using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Randomizer
{
    #region singleton realization
    private static Randomizer instance;

    private Randomizer()
    {
        GenerateWeapons();
    }

    public static Randomizer Instance
    {
        get
        {
            if (instance == null)
                instance = new Randomizer();

            return instance;
        }
    }
    #endregion

    public List<WeaponGetChance> weapons = new List<WeaponGetChance>();
    public int attempts = 5;
    private Weapon Last;

    public void GenerateWeapons()
    {
        AddWeapon(60f,
            () =>
            {
                var rand = new Random();
                var quality = (Quality)(rand.Next() % 2);
                var type = (Type)(rand.Next() % 3 + 1);

                return new Weapon()
                {
                    Name = $"{quality} {type}",
                    Quality = quality,
                    Type = type
                };
            });

        AddWeapon(20f,
            () =>
            {
                var type = (Type)(new Random().Next() % 4);

                return new Weapon()
                {
                    Name = $"norm {type}",
                    Quality = Quality.norm,
                    Type = type
                };
            });

        AddWeapon(15f,
            () =>
            {
                var type = (Type)(new Random().Next() % 4);

                return new Weapon()
                {
                    Name = $"good {type}",
                    Quality = Quality.good,
                    Type = type
                };
            });

        AddWeapon(5f,
            () =>
            {
                var type = (Type)(new Random().Next() % 4);

                return new Weapon()
                {
                    Name = $"norm {type}",
                    Quality = Quality.norm,
                    Type = type
                };
            });
    }

    public void AddWeapon(float chance, Func<Weapon> weapon)
    {
        var last = weapons.LastOrDefault();
        var minChance = 0f;

        if (last != null)
            minChance = last.max;

        weapons.Add(new WeaponGetChance()
        {
            min = minChance,
            max = minChance + chance,
            getWeapon = weapon
        });
    }



    public Weapon GetWeapon()
    {
        var rand = (float)new Random().NextDouble() * 100 % weapons.Last().max;
        var weapon = weapons.FirstOrDefault(w => rand > w.min && rand < w.max).getWeapon();

        if (weapon.Type == Type.knife && Last.Type == Type.knife)
        {
            do
            {
                weapon = weapons.FirstOrDefault(w => rand > w.min && rand < w.max).getWeapon();
            } while (weapon.Type == Type.knife);
        }

        Last = weapon;
        return weapon;
    }
}
