using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MyHandScript : MonoBehaviour
{
    float indexPinchingvalue;
    float middlePinchingvalue;
    Vector3 OtherGameObject;
    

    OVRHand _OVRHand;
    float Pinchvalue = 0.3f;
    //[SerializeField] TextMeshProUGUI PinchValueText;

    // Start is called before the first frame update
    void Start()
    {
        _OVRHand = GetComponent<OVRHand>();
    }

    // Update is called once per frame
    void Update()
    {
        indexPinchingvalue = _OVRHand.GetFingerPinchStrength(OVRHand.HandFinger.Index);
        middlePinchingvalue = _OVRHand.GetFingerPinchStrength(OVRHand.HandFinger.Middle);
        //PinchValueText.text = indexPinchingvalue.ToString("F1");
    }

    private void OnTriggerStay(Collider other)
    {
        //Debug.Log("Enter");
        if (indexPinchingvalue >= Pinchvalue && (other.gameObject.tag == "Text" || other.gameObject.tag == "KeyBoardControl" || other.gameObject.tag == "Pencil"))
        {
            //Debug.Log("Enter2");
            other.gameObject.transform.parent = gameObject.transform;

        }

        //else if(indexPinchingvalue >= Pinchvalue && other.gameObject.tag == "KeyBoardControl")
        //{
        //    other.gameObject.transform.parent = gameObject.transform;
        //}

        else if (indexPinchingvalue <= Pinchvalue && (other.gameObject.tag == "Text" || other.gameObject.tag == "KeyBoardControl" || other.gameObject.tag == "Pencil"))
        {
            OtherGameObject = other.gameObject.transform.position;
            other.gameObject.transform.parent = null;
            other.gameObject.transform.position = OtherGameObject;
        }
    }
}
