using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy
{
    public string name { get; protected set; }
    public int hp { get; protected set; }
    public int power { get; protected set; }

    public abstract void Attack();
    
}

public class Slime : Enemy
{
    public Slime()
    {
        name = "Slime";
        hp = 100;
        power = 10;
    }
    public override void Attack()
    {
        Debug.Log($"Be attacked by {name} ; Get {power} Damaged");
    }
}

public class Goblin : Enemy
{
    public Goblin()
    {
        name = "Goblin";
        hp = 150;
        power = 15;
    }
    public override void Attack()
    {
        Debug.Log($"Be attacked by {name} ; Get {power} Damaged");

    }
}

public class Skeleton : Enemy
{
    public Skeleton()
    {
        name = "Skeleton";
        hp = 200;
        power = 20;
    }
    public override void Attack()
    {
        Debug.Log($"Be attacked by {name} ; Get {power} Damaged");

    }
}
public class DarkMage : Enemy
{
    public DarkMage()
    {
        name = "DarkMage";
        hp = 250;
        power = 25;
    }
    public override void Attack()
    {
        Debug.Log($"Be attacked by {name} ; Get {power} Damaged");

    }
}
public class Scorpion : Enemy
{
    public Scorpion()
    {
        name = "Scorpion";
        hp = 300;
        power = 30;
    }
    public override void Attack()
    {
        Debug.Log($"Be attacked by {name} ; Get {power} Damaged");

    }
}
public class SandGolen : Enemy
{
    public SandGolen()
    {
        name = "SandGolen";
        hp = 350;
        power = 35;
    }
    public override void Attack()
    {
        Debug.Log($"Be attacked by {name} ; Get {power} Damaged");

    }
}
