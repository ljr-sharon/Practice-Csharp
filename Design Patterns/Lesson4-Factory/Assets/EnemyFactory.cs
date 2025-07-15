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
    public abstract Enemy CreateEnemy(LevelType level); 
}

public class ForestType : EnemyFactory
{
    // slime,Goblin
}
public class DungeonType : EnemyFactory
{
    // skeleton,DarkMage
}
public class DesertType : EnemyFactory
{
    // Scorpion,SandGolen
}
