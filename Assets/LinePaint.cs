using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinePaint : MonoBehaviour
{
    [SerializeField] GameObject LineObjectPrefab;
    [SerializeField] Transform HandAnchor;

    [SerializeField]OVRHand _OVRHand;

    [SerializeField] FontSizeSlider PencilSizeSlider;

    private GameObject CurrentLineObject = null;


    private Transform Pointer
    {
        get { return HandAnchor; }
    }

    float indexmiddlevalue;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        var pointer = Pointer;
        if(pointer == null)
        {
            Debug.Log("pointer not defiend");
            return;
        }

        indexmiddlevalue = _OVRHand.GetFingerPinchStrength(OVRHand.HandFinger.Middle);

        if(indexmiddlevalue >= 0.5f)
        {
            if(CurrentLineObject == null)
            {
                //PrefabからLineObjectを生成
                CurrentLineObject = Instantiate(LineObjectPrefab, transform.position, Quaternion.identity);
            }

            //ゲームオブジェクトからLineRendererコンポーネントを取得
            LineRenderer renderer = CurrentLineObject.GetComponent<LineRenderer>();

            //LineRendererからPositionsのサイズを取得
            int NextPositionIndex = renderer.positionCount;

            //LineRendererのPositionsのサイズを増やす
            renderer.positionCount = NextPositionIndex + 1;

            //LineRendererのPositionsに現在のコントローラーの位置情報を追加
            renderer.SetPosition(NextPositionIndex, pointer.position);

        }

        else if (indexmiddlevalue <= 0.49f)
        {
            if(CurrentLineObject != null)
            {
                //現在描画中の線があったらnullにして次の線を描けるようにする。
                CurrentLineObject = null;
            }
        }

        
        
    }

    

    
}
