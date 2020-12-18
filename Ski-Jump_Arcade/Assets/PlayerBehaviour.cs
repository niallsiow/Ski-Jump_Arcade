using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    Rigidbody myRigidbody;

    public float forceAmount;

    bool start = true;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if(start == true)
        {
            myRigidbody.useGravity = false;
        }
        
        Vector3 force = transform.forward * forceAmount;

        if (Input.GetButtonDown("Fire1") && start == true) {
            myRigidbody.useGravity = true;
            start = false;
            myRigidbody.AddForce(force, ForceMode.Impulse);
        }
    }
}
