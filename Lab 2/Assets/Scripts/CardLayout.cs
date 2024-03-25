using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardLayout : MonoBehaviour
{
    public int LayoutId;    // индекс Layout-а 
    public Vector2 Offsеt;  // на сколько сдвигается каждая последующая карта в layout-e
    public bool FaceUp;
    private void Update()
    {
        
    }
    void Rotate()
    {
        FaceUp = !FaceUp;
    }
}
