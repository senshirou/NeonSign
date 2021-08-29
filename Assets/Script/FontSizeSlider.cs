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
    [SerializeField] LineRenderer LineObject;

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        if(gameObject.name == "PencilSizeSlider")
        {
            slider.onValueChanged.AddListener(OnsliderLineRenderer);
        }
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

    
        
    

    void OnsliderObject(float value)
    {
        SampleObject.transform.localScale = new Vector3(value, value, value);
    }

    void Onslider(float value)
    {
        Text.fontSize = value;
    }

    void OnsliderLineRenderer(float value)
    {
       LineObject.startWidth = value;
       LineObject.endWidth = value;
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
