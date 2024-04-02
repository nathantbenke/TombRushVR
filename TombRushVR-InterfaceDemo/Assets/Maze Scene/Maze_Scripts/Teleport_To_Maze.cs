using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_To_Maze : MonoBehaviour
{

    // public Transform teleportTarget;
    public GameObject thePlayer;
    public GameObject theTorchTeleportStartRoom;
    public GameObject theTorchTeleportMaze;
    

    void OnTriggerEnter()
    {
        thePlayer.transform.position = theTorchTeleportMaze.transform.position;
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
        theTorchTeleportStartRoom.tag = "Torch_Teleport_To_Maze";
        theTorchTeleportMaze.tag = "Torch_In_Maze";
    }

    // Update is called once per frame
    void Update()
    {
        
        bool CheckCloseToTag(string tag, float minimumDistance)
            {
                GameObject[] goWithTag = GameObject.FindGameObjectsWithTag(tag);
            
                
                for (int i = 0; i < goWithTag.Length; ++i)
                {
                    if (Vector3.Distance(transform.position, goWithTag[i].transform.position) <= minimumDistance)
                        return true;
                }
            
                return false;
            }

            float min_distance = 0.002f;

            if(CheckCloseToTag(theTorchTeleportStartRoom.tag, min_distance))
            {
                    OnTriggerEnter();
            }


            
    }
}
