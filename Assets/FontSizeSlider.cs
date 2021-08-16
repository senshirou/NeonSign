using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FontSizeSlider : MonoBehaviour
{
    TextMeshPro Text;
    Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    public void MojiTouchGetComponent(string GameObjectName)
    {
        Text = GameObject.Find(GameObjectName).GetComponent<TextMeshPro>();
        slider.onValueChanged.AddListener(Onslider);
        slider.value = Text.fontSize;
    }

    void Onslider(float value)
    {
        Text.fontSize = value;
    }

    private void OnTriggerStay(Collider other)
    {
        slider.enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        slider.enabled = false;
    }



    // Update is called once per frame
}
