using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardLayout : MonoBehaviour
{
    public int LayoutId;    // ������ Layout-� 
    public Vector2 Offs�t;  // �� ������� ���������� ������ ����������� ����� � layout-e
    public bool FaceUp;
    private void Update()
    {
        
    }
    void Rotate()
    {
        FaceUp = !FaceUp;
    }
}
