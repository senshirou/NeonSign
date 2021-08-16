using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;

public class ButtonScriptTest2 : MonoBehaviour
{

    ButtonScriptTest _ButtonScriptTest;
    // Start is called before the first frame update
    void Start()
    {
        _ButtonScriptTest = GetComponent<ButtonScriptTest>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        StopContinue().Forget();
    }

    private async UniTaskVoid StopContinue()
    {
        
        await StopTimeContinue(2f);

    }

    IEnumerator StopTimeContinue(float secound)
    {
        _ButtonScriptTest.enabled = false;
        yield return new WaitForSeconds(secound);
        _ButtonScriptTest.enabled = true;

    }
}
