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
       
    }
}

public class Goblin : Enemy
{

}

public class Skeleton : Enemy
{

}
public class DarkMage : Enemy
{

}
public class Scorpion : Enemy
{

}
public class SandGolen : Enemy
{

}

