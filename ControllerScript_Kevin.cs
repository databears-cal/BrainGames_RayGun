using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript_Kevin : MonoBehaviour
{
    public GameObject object_hit;
    public GameObject temp;

    // Start is called before the first frame update
    void Start()
    {
        temp = new GameObject();
        object_hit = temp;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        transform.rotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.RTrackedRemote);

        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.collider != null)
            {
                if (object_hit != hit.collider.gameObject)
                {
                    object_hit.transform.SendMessage("OnVRExit");
                    object_hit = hit.transform.gameObject;
                    Debug.Log("On VR Enter");
                    object_hit.transform.SendMessage("OnVREnter") ;
                }
                if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
                {
                    object_hit.transform.SendMessage("OnVRTriggerDown");
                }
            }
        } else
        {
            if (object_hit != null)
            {
                object_hit.transform.SendMessage("OnVRExit");
                object_hit = temp;
            }
        }
    }
}
