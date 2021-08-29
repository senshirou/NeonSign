using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpperLowerTest : MonoBehaviour
{
    GameObject _GameObject;
    string a;
    string b;
    // Start is called before the first frame update
    void Start()
    {
        _GameObject = GameObject.Find("Cube");
        a = _GameObject.name;
        b = a.ToLower();
        _GameObject.name = b;

    }
}
