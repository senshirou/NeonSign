using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FontSizeSlider : MonoBehaviour
{
    TextMeshPro Text;
    GameObject SampleObject;
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

    public void GameObjectGetComponent(string GameObjectName)
    {
        SampleObject = GameObject.Find(GameObjectName);
        slider.onValueChanged.AddListener(OnsliderObject);
        slider.value = SampleObject.transform.localScale.x;
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

    void OnsliderObject(float value)
    {
        SampleObject.transform.localScale = new Vector3(value, value, value);
    }



    // Update is called once per frame
}
