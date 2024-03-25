using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardGame
{
    private Dictionary<CardInstance, CardView> dict;
    public List<CardAsset> lst;
    public int HandCapacity;    // Число карт в руке игрока
    void StartGame()
    {

    }
    void CreateCardView(CardInstance inst)
    {
        var view = new CardView();
        view.Init(inst);
        dict.Add(inst, view);
    }
    void CreateCard(CardAsset ass, int layout)
    {
        var inst = new CardInstance(ass);
        CreateCardView(inst);
        inst.MoveToLayout(layout);
        RecalculateLayout(layout);
    }
    List<CardInstance> GetCardsInLayout(int layout)
    {
        List<CardInstance> res = new();
        foreach (var item in dict) {
            if (item.Key.LayoutId == layout)
                res.Add(item.Key);
        }
        return res;
    }
    void RecalculateLayout(int layout)
    {
        int pos = 0;
        foreach (var item in dict)
        {
            if (item.Key.LayoutId == layout)
            {
                item.Key.CardPosition = pos;
                ++pos;
            }
        }
    }
    void StartTurn()
    {
        // Раздать игрокам по HandCapacity карт
    }
    void ShuffleLayout(int layoutId)
    {
        
    }
}
