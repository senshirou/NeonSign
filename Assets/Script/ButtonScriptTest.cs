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
    [SerializeField] GameObject GroupObject;

    [SerializeField]TextMeshProUGUI MenuText;

    [SerializeField] GameObject point;
    string GameObjectName;

    FontSizeSlider _FontSizeSlider;

    int SampleObjectCount;
    int SampleObjectInsantiateLimit = 20;

   

    private void Start()
    {

        _Button = GetComponent<Button>();
        Debug.Log(transform.position);

    }


    private void OnTriggerStay(Collider other)
    {
        SampleObjectCount = GameObject.FindGameObjectsWithTag("SampleObject").Length;

        if (other.gameObject.tag == "OVRHand")
        {
            _Button.enabled = true;
            WaitingCircle.enabled = true;
            WaitingCircle.fillAmount += 0.01f;
        }

        else if(WaitingCircle.fillAmount >= 1f && ImageContinuesStop == true && MenuText.text == "Object" && SampleObjectCount <= SampleObjectInsantiateLimit)
        {

            Instantiate(NeonPictureSample, point.transform.position,point.transform.rotation);

            ImageContinuesStop = false;
        }

        else if (WaitingCircle.fillAmount >= 1f && MenuText.text == "Menu")
        {
            //各々のモードをONにする
            MenuButtonObject.SetActive(true);
            Menu.SetActive(false);
            _Button.enabled = false;
            WaitingCircle.enabled = false;
            WaitingCircle.fillAmount = 0;
        }

        else if(WaitingCircle.fillAmount >= 1f && MenuText.text == "Back")
        {
            Menu.SetActive(true);
            GroupObject.SetActive(false);
            _Button.enabled = false;
            WaitingCircle.enabled = false;
            WaitingCircle.fillAmount = 0;
        }

        else if(WaitingCircle.fillAmount >= 1f && MenuText.text =="Hide")
        {
            //MenuObjedtを非表示にする
            MenuButtonObject.SetActive(false);
        }

        else if (WaitingCircle.fillAmount >= 1f && MenuText.text == "TrashLine")
        {
            Destroy(GameObject.FindGameObjectWithTag("LineObject"));
            WaitingCircle.fillAmount = 0.99f;
            if(GameObject.FindGameObjectWithTag("LineObject") == null)
            {
                WaitingCircle.fillAmount = 0;
            }

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








