using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountObject : MonoBehaviour
{
    int count;

    // Start is called before the first frame update
    void Start()
    {
        count = GameObject.FindGameObjectsWithTag("Text").Length;
        Debug.Log(count);
        gameObject.name = "Cube" + (count + 1).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
