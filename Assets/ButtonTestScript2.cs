using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTestScript2 : MonoBehaviour
{
    [SerializeField] Button Button1;
    [SerializeField] Button Button2;

    float RcolorfM;
    float GcolorfM;
    float BcolorfM;
    float AcolorfM = 255;

    [SerializeField] Slider RcolorSlider;
    [SerializeField] Slider GcolorSlider;
    [SerializeField] Slider BcolorSlider;
    [SerializeField] Slider AcolorSlider;

    // Start is called before the first frame update
    void Start()
    {
        RcolorSlider.onValueChanged.AddListener(delegate { ValueChange(); });
        GcolorSlider.onValueChanged.AddListener(delegate { ValueChange(); });
        BcolorSlider.onValueChanged.AddListener(delegate { ValueChange(); });
        AcolorSlider.onValueChanged.AddListener(delegate { ValueChange(); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Button1Control()
    {
        RcolorSlider.value = 0.30f;
        GcolorSlider.value = 0.23f;
        BcolorSlider.value = 0.38f;
        AcolorSlider.value = 1.0f;
    }

    public void ValueChange()
    {

    }
}
