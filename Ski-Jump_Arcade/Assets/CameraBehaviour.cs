using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{

    public Transform playerTransform;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // z value needs to either stay the same or zoom based on player speed


        // x and y value should follow player


        Vector3 targetPos;
        targetPos.x = playerTransform.position.x;
        targetPos.y = playerTransform.position.y;
        targetPos.z = transform.position.z;

        transform.position = targetPos;

        
        // apply smoothing to follow to remove jitter


    }
}
