using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class HandTrackingTest : MonoBehaviour
{
    [SerializeField] TextMeshPro thumbPinchStrengthText;
    [SerializeField] TextMeshPro indexPinchStrengthText;
    [SerializeField] TextMeshPro middlePinchStrengthText;
    [SerializeField] TextMeshPro ringPinchStrengthText;
    [SerializeField] TextMeshPro pinkyPinchStrengthText;

    float a = 10;
    int b = 9;
    

    OVRHand ovrhand;
    // Start is called before the first frame update
    void Start()
    {
        ovrhand = GetComponent<OVRHand>();
    }

    // Update is called once per frame
    void Update()
    {
        //var hand = GetComponent<OVRHand>();


        float isIndexPinching = ovrhand.GetFingerPinchStrength(OVRHand.HandFinger.Index);
        float isThumbPinching = ovrhand.GetFingerPinchStrength(OVRHand.HandFinger.Thumb);
        float isMiddlePinching = ovrhand.GetFingerPinchStrength(OVRHand.HandFinger.Middle);
        float isRingPinching = ovrhand.GetFingerPinchStrength(OVRHand.HandFinger.Ring);
        float isPinkyPinching = ovrhand.GetFingerPinchStrength(OVRHand.HandFinger.Pinky);

        float middlePinchStrength = ovrhand.GetFingerPinchStrength(OVRHand.HandFinger.Middle);

        thumbPinchStrengthText.text = isThumbPinching.ToString("F1");
        indexPinchStrengthText.text = isIndexPinching.ToString("F1");
        middlePinchStrengthText.text = middlePinchStrength.ToString("F1");
        ringPinchStrengthText.text = isRingPinching.ToString("F1");
        pinkyPinchStrengthText.text = isPinkyPinching.ToString("F1");

        int a = (testbool) ? 10 : 9;
        Debug.Log(a);
    }

    public bool testbool
    {
        get
        {
            return a == 9;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }


}
