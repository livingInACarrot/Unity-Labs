using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInstance
{
    CardAsset asset;
    public int LayoutId;      // индекс Layout-a, на котором находится карта
    public int CardPosition;  // текущая позиция карты в layout-e
    public CardInstance(CardAsset asset)
    {
        this.asset = asset;
    }
    public void MoveToLayout(int layout)
    {
        LayoutId = layout;
        CardPosition = 0;    // ?
    }
}
