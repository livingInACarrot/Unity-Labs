using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceVisual : MonoBehaviour
{
    public Text text;
    public GameResource resource;
    
    public void Start()
    {
        text.text = ResourceBank.GetResource(resource).ToString();
    }
    public void Update()
    {
        text.text = ResourceBank.GetResource(resource).ToString();
    }
}
