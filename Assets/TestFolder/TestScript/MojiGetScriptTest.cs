using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MojiGetScriptTest : MonoBehaviour
{
    TextMeshPro Tmp;

    // Start is called before the first frame update
    void Start()
    {
        Tmp = GetComponent<TextMeshPro>();
        Debug.Log(Tmp);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
