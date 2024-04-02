using System;
using System.Diagnostics;
using UnityEngine;

public class DeactivateSpike : MonoBehaviour
{
    public Transform topOfLever;
    public Transform SpawnPoint;
    public GameObject SpikePitCover;

    [SerializeField]
    private float forwardBackwardTilt = 0;
    


    // Update is called once per frame
    void Update()
    {
        bool coverCreated = false;
        SpikePitCover.SetActive(false);

        forwardBackwardTilt = topOfLever.rotation.eulerAngles.z; // Base value is 60
        if (forwardBackwardTilt < 90)
        {
            SpikePitCover.SetActive(false);
        }
        else if (forwardBackwardTilt >= 90)
        {
            //If greater than 90, Activate Platform
            // Maximum value should be 115/120
            SpikePitCover.SetActive(true);
            //createObject(coverCreated);
            //coverCreated = true;

        }
    }
/*
        void createObject (bool created)
        {
            if (!created)
            {
                Instantiate(SpikePitCover, SpawnPoint.position, SpawnPoint.rotation);
            }
        }
*/
}
