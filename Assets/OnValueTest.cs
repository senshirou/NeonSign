using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class OnValueTest : MonoBehaviour
{
    TextMeshPro Text;
    Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        Text = GameObject.Find("Text").GetComponent<TextMeshPro>();
        slider = GetComponent<Slider>();
        slider.onValueChanged.AddListener(Onslider);
        slider.value = Text.fontSize;
        
        
    }

    void Update()
    {

    }

    void Onslider(float value)
    {
        Text.fontSize = value;
    }

    // Update is called once per frame
    
}
