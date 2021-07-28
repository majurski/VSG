using System;
using System.Reflection;

namespace MyApplication
{
class Weapon
{
    
}

class Knife : Weapon
{
    public int damage = 10;
    public void InflictDamage()
    {
        Console.WriteLine($"Knife stabs for {damage} damage!");
    }
    
}

class Gun : Weapon
{
    public int damage = 20;
    public void InflictDamage()
    {
        Console.WriteLine($"Gun shoots for {damage} damage!");
    }
}

class Bow : Weapon
{
    public int damage = 5;
    public void InflictDamage()
    {
        Console.WriteLine($"Bow stabs for {damage} damage!");
    }
}
class Program
{ 
    static void Main(string[] args)
    {
        static void FactoryMathod()
        {
            string typeOfWeapon = Console.ReadLine();

            if (typeOfWeapon == "gun")  
            {  
                // Console.WriteLine("gun");
                Gun gun1 = new Gun();
                gun1.InflictDamage();
            }  
            else if (typeOfWeapon == "bow")  
            {  
                // Console.WriteLine("bow");
                Bow bow1 = new Bow();
                bow1.InflictDamage();
            }
            else
            {
                // Console.WriteLine("knife");
                Knife knife1 = new Knife();
                knife1.InflictDamage();
            }
        }

        FactoryMathod();
        // Console.WriteLine(knife1.damage);
        // Console.WriteLine(gun1.damage);
    }
  }
}
