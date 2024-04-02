using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Idol_Timer : MonoBehaviour
{
    public Transform grabPoint;
    public float grabDistance = 0.5f;
    public LayerMask grabMask;
    // public float timerDuration = 10f;
    
    private bool isGrabbing = false;
    private GameObject grabbedObject = null;
    private float timer = 0f;
    
    public Text myText;
 
    int test = 0;
 
    // var inputDevices = new List<UnityEngine.XR.InputDevice>();
    // UnityEngine.XR.InputDevices.GetDevices(inputDevices);

    // foreach (var device in inputDevices)
    // {
    //     Debug.Log(string.Format("Device found with name '{0}' and role '{1}'", device.name, device.role.ToString()));
    // }

    void Update()
    {

        // If the user isn't grabbing the object, then release
        if (!isGrabbing)
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, grabDistance, grabMask))
            {
                grabbedObject = hit.collider.gameObject;
                grabbedObject.transform.position = grabPoint.position;
                grabbedObject.transform.parent = grabPoint;
                isGrabbing = true;
                timer = 0;
            }
        }



    // If the user is grabbing, then time continues
        if (isGrabbing)
        {
            timer += Time.deltaTime;
            myText.text = "Timer: " + timer;

//             if (timer <= 0f)
//             {
//                 Debug.Log("Time's up!");
//                 ReleaseObject();
//             }
        }

    // If the user has object and presses a "mouse button", then object gets released
        if (isGrabbing && Input.GetMouseButtonUp(0))
        {
            ReleaseObject();
        }



    }





    void ReleaseObject()
    {
//         grabbedObject.transform.parent = null;
        isGrabbing = false;
//         grabbedObject = null;
//         timer = 0f;
    }
}

