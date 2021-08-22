using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Cysharp.Threading.Tasks;
using System;

public class MojiInputScript : MonoBehaviour
{
    
    [SerializeField]TextMeshPro Tmpro;
    TextMeshPro MyText;
    string MyAlphabet;
    bool StopTime = true;
    
    

    // Start is called before the first frame update
    void Start()
    {
        MyText = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(StopTime == true)
        {
            MyAlphabet = gameObject.name;
            try
            {
                Tmpro.text += MyAlphabet;
            }

            catch(NullReferenceException e)
            {
                Debug.Log("•¶Žš‚ðˆ¬‚Á‚Ä‚­‚¾‚³‚¢");
            }
            //Tmpro.text += MyAlphabet;
            StopTimeText(0.5f).Forget();
        }
        
    }

    public void MojiTouchGetComponent(string InputTextName)
    {
        Tmpro = GameObject.Find(InputTextName).GetComponent<TextMeshPro>();
    }

    private async UniTaskVoid StopTimeText(float secound)
    {
        StopTime = false;
        await StopTimeColutine(secound);
        StopTime = true;
    }

    IEnumerator StopTimeColutine(float secound)
    {
        yield return new WaitForSeconds(secound);

    }
}
