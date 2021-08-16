using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cysharp.Threading.Tasks;


[RequireComponent(typeof(BoxCollider))]
public class ButtonScriptTest : MonoBehaviour
{

    Button _Button;
    bool StopContinues = true;

    //オブジェクトの生成
    [SerializeField] Image WaitingCircle;
    [SerializeField] GameObject NeonPictureSample;
    bool ImageContinuesStop = true;
    //[SerializeField] GameObject positions;
    
    
    

    private void Start()
    {
        _Button = GetComponent<Button>();
        
        Debug.Log(transform.position);
        
        
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "OVRHand")
        {
            _Button.enabled = true;
            WaitingCircle.enabled = true;
            WaitingCircle.fillAmount += 0.01f;
        }

        else if(WaitingCircle.fillAmount >= 1f && ImageContinuesStop == true)
        {
            Instantiate(NeonPictureSample,transform.position , NeonPictureSample.transform.rotation);
            ImageContinuesStop = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "OVRHand")
        {
            Debug.Log("Exit");
            _Button.enabled = false;
            WaitingCircle.enabled = false;
            WaitingCircle.fillAmount = 0;
            ImageContinuesStop = true;
        }
    }
}








