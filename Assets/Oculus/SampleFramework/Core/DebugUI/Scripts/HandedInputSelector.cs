/************************************************************************************

Copyright (c) Facebook Technologies, LLC and its affiliates. All rights reserved.  

See SampleFramework license.txt for license terms.  Unless required by applicable law 
or agreed to in writing, the sample code is provided ìAS ISÅEWITHOUT WARRANTIES OR 
CONDITIONS OF ANY KIND, either express or implied.  See the license for specific 
language governing permissions and limitations under the license.

************************************************************************************/
using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;

public class HandedInputSelector : MonoBehaviour
{
    OVRCameraRig m_CameraRig;
    OVRInputModule m_InputModule;

    public Transform t;

    void Start()
    {
        m_CameraRig = FindObjectOfType<OVRCameraRig>();
        m_InputModule = FindObjectOfType<OVRInputModule>();
    }

    void Update()
    {
        if(OVRInput.GetActiveController() == OVRInput.Controller.LTouch)
        {
            SetActiveController(OVRInput.Controller.LTouch);
        }

        else if(OVRInput.GetActiveController() == OVRInput.Controller.Hands)
        {
            SetActiveController(OVRInput.Controller.Hands);
        }

        else
        {
            SetActiveController(OVRInput.Controller.RTouch);
        }

        var pointer = t;

        
        

    }

    void SetActiveController(OVRInput.Controller c)
    {
        //Transform t;
        if(c == OVRInput.Controller.LTouch || c == OVRInput.Controller.Hands)
        {
            t = m_CameraRig.rightHandAnchor;
        }
        else
        {
            t = m_CameraRig.rightHandAnchor;
        }
        m_InputModule.rayTransform = t;
    }


}
