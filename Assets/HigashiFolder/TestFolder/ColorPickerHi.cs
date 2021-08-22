using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.UI;

public class ColorPickerHi : MonoBehaviour
{
    //TextMeshProUGUI GUi;
    TextMeshProUGUI find;
    


    // Start is called before the first frame update
    void Start()
    {
        //GUi = GetComponent<TextMeshProUGUI>();
        find = GameObject.Find("Picker 2.0/ColorField/InputField (TMP)/Text Area/Text").GetComponent<TextMeshProUGUI>();
        //"InputField (TMP)/Text Area"

    }

    // Update is called once per frame
    void Update()
    {
        //HSVPicker.HexColorField test = new HSVPicker.HexColorField();
        //test.Test();
        Debug.Log(find.text);
    }   
}
