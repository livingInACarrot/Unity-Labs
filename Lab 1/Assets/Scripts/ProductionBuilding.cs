using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ProductionBuilding : MonoBehaviour
{
    public GameResource resource;
    public Levels resourcelvl;
    public Slider slider;
    public Button button;
    public TMP_Text lvlButton;
    public float ProductionTime = 5; // seconds
    float time = 5;
    float current;
    bool stopSlider = true;
    public void ButtonClick()
    {
        time = ProductionTime*(1 - (float)ResourceBank.GetLvl(resourcelvl)/100);
        slider.maxValue = time;
        slider.value = 0;
        stopSlider = false;
        current = 0;
        button.interactable = false;
        StartCoroutine(StartTimer());
    }
    IEnumerator StartTimer()
    {
        while (stopSlider == false)
        {
            current += Time.deltaTime;
            yield return new WaitForSeconds(0.001f);
            if (current >= time)
                stopSlider = true;
            if (stopSlider == false)
                slider.value = current;
        }
        ResourceBank.ChangeResource(resource, 1);
        slider.value = 0;
        button.interactable = true;
    }
    public void LevelButtonClick()
    {
        lvlButton.text = "lvl " + ResourceBank.LevelUp(resourcelvl);
    }
}
