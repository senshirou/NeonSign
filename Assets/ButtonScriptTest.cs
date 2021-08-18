using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cysharp.Threading.Tasks;
using TMPro;


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


    [SerializeField] GameObject MenuButtonObject;
    [SerializeField] GameObject Menu;

    [SerializeField]TextMeshProUGUI MenuText;
    

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

        else if(WaitingCircle.fillAmount >= 1f && ImageContinuesStop == true && MenuText.text == "Object")
        {
            Instantiate(NeonPictureSample,transform.position , NeonPictureSample.transform.rotation);
            ImageContinuesStop = false;
        }

        else if (WaitingCircle.fillAmount >= 1f && MenuText.text == "Menu")
        {
            //各々のモードをONにする
            MenuButtonObject.SetActive(true);        
        }

        else if(WaitingCircle.fillAmount >= 1f && MenuText.text =="Hide")
        {
            //MenuObjedtを非表示にする
            MenuButtonObject.SetActive(false);
        }

        string a = other.gameObject.name;
        


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

        Debug.Log("Exit");

    }
}








