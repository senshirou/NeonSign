using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using Cysharp.Threading.Tasks;

public class OtherKey : MonoBehaviour
{
    [SerializeField] TextMeshPro Tmpro;

    TextMeshPro KeyboardText;

    public List<string> FontList = new List<string>();
    int ListCount = 0;
    string Alphabetgroup = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    GameObject Keyborad;
    String AlphabetKey;




    bool UpperLowerbool = true;

    bool ContinuousInputStop = true;
    bool FontChangeInputStop = true;
    bool StopInputContinuouslyBool = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKey(KeyCode.N) && ContinuousInputStop == true)
        //{
        //    string s = Tmpro.text.Substring(0, Tmpro.text.Length - 1);
        //    Tmpro.text = s.ToString();
        //    StopTimeBack().Forget();



        //}

        //Debug.Log(UpperLowerbool);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.name == "Back" && ContinuousInputStop == true)
        {
            string s = Tmpro.text.Substring(0, Tmpro.text.Length - 1);
            Tmpro.text = s.ToString();
            StopTimeBack().Forget();

        }

        else if (gameObject.name == "FontChange" && FontChangeInputStop == true)
        {
            ++ListCount;
            ListCount = (FontList.Count == ListCount) ? 0 : ListCount;
            //string str = "a";
            //result = result + str;
            //Tmpro.text = result.ToString();
            TMP_FontAsset fontchange = Resources.Load<TMP_FontAsset>(FontList[ListCount]);
            Tmpro.font = fontchange;
            StopTimeFontChange().Forget();
        }

        else if (gameObject.name == "UpperLower" && UpperLowerbool == true && StopInputContinuouslyBool == true)
        {
            for (int i = 0; i < Alphabetgroup.Length; i++)
            {
                char Alphabet = Alphabetgroup[i];
                AlphabetKey = Alphabet.ToString().ToLower();
                Keyborad = GameObject.Find(Alphabet.ToString());
                KeyboardText = GameObject.Find(Alphabet.ToString()).GetComponent<TextMeshPro>();
                KeyboardText.text = AlphabetKey;
                Keyborad.name = AlphabetKey;
                
                UpperLowerbool = false;
                //UpperLowerbool = !UpperLowerbool;
                StopInputContinuously().Forget();
            }
        }



        else if (gameObject.name == "UpperLower" && UpperLowerbool == false && StopInputContinuouslyBool == true)
        {
            for (int i = 0; i < Alphabetgroup.Length; i++)
            {
                char Alphabet = Alphabetgroup[i];
                Debug.Log(Alphabet.ToString());
                AlphabetKey = Alphabet.ToString().ToLower();
                Keyborad = GameObject.Find(AlphabetKey);
                KeyboardText = GameObject.Find(AlphabetKey).GetComponent<TextMeshPro>();
                Keyborad.name = Alphabet.ToString();
                KeyboardText.text = Alphabet.ToString();
                UpperLowerbool = true;
                StopInputContinuously().Forget();
            }
        }
    }

    private async UniTaskVoid StopTimeBack()
    {
        ContinuousInputStop = false;
        await StopTimeColutine(0.5f);
        ContinuousInputStop = true;
    }

    private async UniTaskVoid StopTimeFontChange()
    {
        FontChangeInputStop = false;
        await StopTimeColutine(0.5f);
        FontChangeInputStop = true;
    }

    privateÅ@async UniTaskVoid StopInputContinuously()
    {
        StopInputContinuouslyBool = false;
        await StopTimeColutine(1f);
        StopInputContinuouslyBool = true;
    }

    public void MojiTouchGetComponent(string InputTextName)
    {
        Tmpro = GameObject.Find(InputTextName).GetComponent<TextMeshPro>();
    }


    IEnumerator StopTimeColutine(float secound)
    {
        yield return new WaitForSeconds(secound);

    }

    
}
