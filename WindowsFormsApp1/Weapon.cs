using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Weapon
{
    public Weapon()
    {

    }

    public string Name { get; set; }
    public Type Type { get; set; }
    public Quality Quality { get; set; }
}
public enum Type
{
    knife,
    pistol,
    rifle,
    shotgun
}

public enum Quality
{
    shit,
    almoustShit,
    norm,
    good,
    nice
}

public class WeaponGetChance
{
    public WeaponGetChance()
    {

    }

    public float min;
    public float max;
    public Func<Weapon> getWeapon;
}