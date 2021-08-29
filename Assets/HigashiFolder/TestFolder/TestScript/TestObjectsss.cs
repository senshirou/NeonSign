using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObjectsss : MonoBehaviour
{
    Rigidbody rb;
    string MyObjectName;

    // Start is called before the first frame update
    void Start()
    {
        MyObjectName = gameObject.name;
        rb = GameObject.Find(gameObject.name + "TestObjects").GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
