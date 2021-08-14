using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InputFieldText : MonoBehaviour
{
    TextMeshPro InputFieldTexts;
    string Gameobjectname;
    string FontText = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
    string FontChangeString = "FontChange";
    string BackString = "Back";
    string FontSizeString = "FontSizeSilder";
    FontSizeSlider _FontSizeSlider;
    MojiInputScript _MojiInputScript;
    OtherKey _OtherKey;
    List<string> OtherKeys = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        InputFieldTexts = GetComponent<TextMeshPro>();
        InputFieldTexts.text = "A".ToString();
        Gameobjectname = gameObject.name;
        OtherKeys.Add(FontChangeString);
        OtherKeys.Add(BackString);
        
        
    }

    private void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < FontText.Length; i++)
        {
            char GameObjectOneText = FontText[i];
            _MojiInputScript = GameObject.Find(GameObjectOneText.ToString()).GetComponent<MojiInputScript>();
            _MojiInputScript.MojiTouchGetComponent(Gameobjectname);

        }

        for (int i = 0; i < OtherKeys.Count; i++)
        {
            _OtherKey = GameObject.Find(OtherKeys[i]).GetComponent<OtherKey>();
            _OtherKey.MojiTouchGetComponent(Gameobjectname);
        }

        _FontSizeSlider = GameObject.Find(FontSizeString).GetComponent<FontSizeSlider>();
        _FontSizeSlider.MojiTouchGetComponent(Gameobjectname);

    }
}
