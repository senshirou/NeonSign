using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTest : MonoBehaviour
{
    [SerializeField] Button button;
    bool test = true;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(ShowLog);
    }

    // Update is called once per frame
    void ShowLog()
    {
        if(!test)
        {
            Debug.Log("false");
            Debug.Log(test);
            test = !test;
        }

        else
        {
            Debug.Log("true");
            Debug.Log(test);
            test = !test;
        }
    }
}
