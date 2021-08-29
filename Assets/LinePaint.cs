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
                //Prefab����LineObject�𐶐�
                CurrentLineObject = Instantiate(LineObjectPrefab, transform.position, Quaternion.identity);
            }

            //�Q�[���I�u�W�F�N�g����LineRenderer�R���|�[�l���g���擾
            LineRenderer renderer = CurrentLineObject.GetComponent<LineRenderer>();

            //LineRenderer����Positions�̃T�C�Y���擾
            int NextPositionIndex = renderer.positionCount;

            //LineRenderer��Positions�̃T�C�Y�𑝂₷
            renderer.positionCount = NextPositionIndex + 1;

            //LineRenderer��Positions�Ɍ��݂̃R���g���[���[�̈ʒu����ǉ�
            renderer.SetPosition(NextPositionIndex, pointer.position);

        }

        else if (indexmiddlevalue <= 0.49f)
        {
            if(CurrentLineObject != null)
            {
                //���ݕ`�撆�̐�����������null�ɂ��Ď��̐���`����悤�ɂ���B
                CurrentLineObject = null;
            }
        }

        
        
    }

    

    
}
