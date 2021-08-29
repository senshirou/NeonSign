using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class TextColorChange : MonoBehaviour
{
    [SerializeField]TextMeshPro text;
    TextMeshProUGUI RColorText;
    TextMeshProUGUI GColorText;
    TextMeshProUGUI BColorText;
    TextMeshProUGUI AColorText;

    [SerializeField] Slider RcolorSlider;
    [SerializeField] Slider GcolorSlider;
    [SerializeField] Slider BcolorSlider;
    [SerializeField] Slider AcolorSlider;
    [SerializeField] Slider HueSlider;
    [SerializeField] GameObject ColorBox;

    [SerializeField] LineRenderer _LineObject;
    

    float RcolorfM;
    float GcolorfM;
    float BcolorfM;
    float AcolorfM = 255;
    // Start is called before the first frame update
    void Start()
    {
        RcolorSlider.onValueChanged.AddListener(delegate { ValueChange(); });
        GcolorSlider.onValueChanged.AddListener(delegate { ValueChange(); });
        BcolorSlider.onValueChanged.AddListener(delegate { ValueChange(); });
        AcolorSlider.onValueChanged.AddListener(delegate { ValueChange(); });
    }

    // Update is called once per frame
    //void Update()
    //{
    //    int Rcolorf = int.Parse(RColorText.text);
    //    int Gcolorf = int.Parse(GColorText.text);
    //    int Bcolorf = int.Parse(BColorText.text);
    //    int Acolorf = int.Parse(AColorText.text);
    //    text.color = new Color(Rcolorf/255f, Gcolorf/255f, Bcolorf/255f, Acolorf/255f); 
    //    Debug.Log(text.color.ToString("F3"));
    //}

    public void InputText(string InputFieldName)
    {
        text = GameObject.Find(InputFieldName).GetComponent<TextMeshPro>();
        //text.color = new Color(RcolorSlider.value, GcolorSlider.value , BcolorSlider.value, AcolorSlider.value);
    }

    void ValueChange()
    {
        try
        {
            if (text.gameObject.tag == "Text")
            {
                text.color = new Color(RcolorSlider.value, GcolorSlider.value, BcolorSlider.value, AcolorSlider.value);
                Debug.Log("Change");

                RcolorfM = RcolorSlider.value;
                GcolorfM = GcolorSlider.value;
                BcolorfM = BcolorSlider.value;
                AcolorfM = AcolorSlider.value;
            }
        }
        catch(NullReferenceException)
        {
            if (transform.root.gameObject.name == "PencilSlider")
            {
                Debug.Log("kita");
                _LineObject.startColor = new Color(RcolorSlider.value, GcolorSlider.value, BcolorSlider.value, AcolorSlider.value);
            }
        }

        
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag =="OVRHand")
        {
            RcolorSlider.enabled = true;
            GcolorSlider.enabled = true;
            BcolorSlider.enabled = true;
            AcolorSlider.enabled = true;
            HueSlider.enabled = true;
            ColorBox.SetActive(true);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "OVRHand")
        {
            RcolorSlider.enabled = false;
            GcolorSlider.enabled = false;
            BcolorSlider.enabled = false;
            AcolorSlider.enabled = false;
            HueSlider.enabled = false;
            ColorBox.SetActive(false);
        }
    }


}
