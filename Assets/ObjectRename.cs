using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRename : MonoBehaviour
{

    int ObjectCount;
    string OldgameobjectName;


    // Start is called before the first frame update
    void Start()
    {
        ObjectCount = GameObject.FindGameObjectsWithTag("SampleObject").Length;
        OldgameobjectName = gameObject.name;
        gameObject.name = OldgameobjectName + (++ObjectCount).ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "OVRHand")
        {
            FontSizeSlider _FontSizeSlider = GameObject.Find("SampleSizeSilder").GetComponent<FontSizeSlider>();
            _FontSizeSlider.GameObjectGetComponent(gameObject.name);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.name == "Trash")
        {
            Destroy(gameObject);
        }
    }
}
