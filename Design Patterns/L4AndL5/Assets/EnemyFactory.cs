using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum LevelType
{
    None,
    Forest,
    Dungeon,
    Desert
}

public abstract class EnemyFactory
{
    public LevelType type;
  
    public abstract Enemy CreateEnemy();
}

public class ForestType : EnemyFactory
{
    private static System.Random rand = new System.Random();
    private int dice;
    public int GetDice()
    {
        dice = rand.Next(0, 1);
        return dice;
    }
    public ForestType()
    {
        dice = GetDice();
        type = LevelType.Forest;
    }
    // slime,Goblin
    public override Enemy CreateEnemy()
    {
        if (dice == 0)
        {
            return new Slime();
        }
        else
        {
            return new Goblin();
        }
    }
}
public class DungeonType : EnemyFactory
{
    private static System.Random rand = new System.Random();
    private int dice;
    public int GetDice()
    {
        dice = rand.Next(0, 1);
        return dice;
    }
    public DungeonType()
    {
        dice = GetDice();
        type = LevelType.Dungeon;
    }
    // skeleton,DarkMage
    public override Enemy CreateEnemy()
    {
        if (dice == 0)
        {
            return new Skeleton();
        }
        else
        {
            return new DarkMage();
        }
    }
}
public class DesertType : EnemyFactory
{
    private static System.Random rand = new System.Random();
    private int dice;
    public int GetDice()
    {
        dice = rand.Next(0, 1);
        return dice;
    }
    public DesertType()
    {
        dice = GetDice();
        type = LevelType.Desert;
    }
    // Scorpion,SandGolen
    public override Enemy CreateEnemy()
    {
        if (dice == 0)
        {
            return new Scorpion();
        }
        else
        {
            return new SandGolen();
        }
    }
}

