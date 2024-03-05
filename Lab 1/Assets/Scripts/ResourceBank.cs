using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameResource
{
    Humans,
    Food,
    Wood,
    Stone,
    Gold
}
public enum Levels
{
    HumansLvl,
    FoodLvl,
    WoodLvl,
    StoneLvl,
    GoldLvl
}

public static class ResourceBank
{
    static Dictionary<GameResource, int> dict = new(){
    { GameResource.Humans, 0},
    { GameResource.Food, 0},
    { GameResource.Wood, 0},
    { GameResource.Stone, 0},
    { GameResource.Gold, 0}
    };
    static Dictionary<Levels, int> levels = new(){
    { Levels.HumansLvl, 1},
    { Levels.FoodLvl, 1},
    { Levels.WoodLvl, 1},
    { Levels.StoneLvl, 1},
    { Levels.GoldLvl, 1}
    };
    public static void ChangeResource(GameResource r, int v)
    {
        dict[r] += v;
    }
    public static int GetResource(GameResource r)
    {
        return dict[r];
    }
    public static void GetStarted()
    {
        dict[GameResource.Humans] = 10;
        dict[GameResource.Food] = 5;
        dict[GameResource.Wood] = 5;
    }  
    public static int LevelUp(Levels r)
    {
        if (levels[r] < 99)
            ++levels[r];
        return levels[r];
    }
    public static int GetLvl(Levels r)
    {
        return levels[r];
    }
}
