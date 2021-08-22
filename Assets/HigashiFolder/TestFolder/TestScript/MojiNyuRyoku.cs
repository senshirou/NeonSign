using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MojiNyuRyoku : MonoBehaviour
{
    [SerializeField] TextMeshPro Tmpro;
    
    public List<string> FontList = new List<string>();
    string result = "";
    int ListCount = 0;

    int FontListCountOver;
    // Start is called before the first frame update
    void Start()
    {
        
        
        FontListCountOver = FontList.Count + 1;
        Debug.Log(FontListCountOver);

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ++ListCount;
            ListCount = (FontList.Count == ListCount) ? 0 : ListCount;
            //string str = "a";
            //result = result + str;
            //Tmpro.text = result.ToString();
            TMP_FontAsset fontchange = Resources.Load<TMP_FontAsset>(FontList[ListCount]);
            Tmpro.font = fontchange;
            Debug.Log(ListCount);
            
            
            
        }
    }
}
