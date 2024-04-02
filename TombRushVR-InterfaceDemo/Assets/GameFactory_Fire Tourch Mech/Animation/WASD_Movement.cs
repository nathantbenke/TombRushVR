using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD_Movement : MonoBehaviour
{

    public GameObject GameFactory_TourchAnimations;
    // public static Rigidbody rb = GetComponent<Rigidbody>();
    public Rigidbody rb;

    float speed = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
        // rb.position = GameFactory_TourchAnimations.position;

        // rb = GetComponent<Rigidbody>();

        // rb.position = GameFactory_TourchAnimations.transform.position;
        
    // Start is called before the first frame update
        speed = 1.0f;
        // GameObject[] goWithTag = GameObject.FindGameObjectsWithTag("Person_Moving");

        //  for (int i = 0; i < goWithTag.Length; ++i)
        //         {
        //                     rb.position = goWithTag[i].transform.position;

                   
        //         }
        rb = GetComponent<Rigidbody>();
        
        
        GameObject[] arr = GameObject.FindGameObjectsWithTag("Person_Moving");
        GameFactory_TourchAnimations = arr[0];
        // GameFactory_TourchAnimations = GetComponent<GameObject>();
    }

    // Update is called once per frame
 void Update() {
        // Rigidbody rb = GetComponent<Rigidbody>();
    //     if (Input.GetKey(KeyCode.A))
    //         rb.AddForce(Vector3.left);
    //     if (Input.GetKey(KeyCode.D))
    //         rb.AddForce(Vector3.right);
    //     if (Input.GetKey(KeyCode.W))
    //         rb.AddForce(Vector3.up);
    //     if (Input.GetKey(KeyCode.S))
    //         rb.AddForce(Vector3.down);

     if (Input.GetKey(KeyCode.W))
        {
    
            GameFactory_TourchAnimations.transform.Translate(Vector3.forward * Time.deltaTime * speed);
            // rb.AddForce(Vector3.up);
            Debug.Log("W is pressed");
          }
        if (Input.GetKey(KeyCode.S))
        { 
            GameFactory_TourchAnimations.transform.Translate(-1 * Vector3.forward * Time.deltaTime * speed);
            //  rb.AddForce(Vector3.down);
            Debug.Log("S is pressed");

        }
        if (Input.GetKey(KeyCode.A)) { 
            GameFactory_TourchAnimations.transform.Rotate(0, -1, 0);
            //  rb.AddForce(Vector3.left);
             Debug.Log("A is pressed");
            
        }
        if (Input.GetKey(KeyCode.D))
        {
            GameFactory_TourchAnimations.transform.Rotate(0, 1, 0);
            // rb.AddForce(Vector3.right);
             Debug.Log("D is pressed");
           
        }
    }  

}
