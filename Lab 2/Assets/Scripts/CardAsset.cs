using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardAsset : ScriptableObject
{
    public int cardvalue; // 6, 7, ..., J = 11, D = 12, K = 13, A = 14
    public string suit;   // Diamonds, Hearts, Clubs, Spades
    public Image image;
}
