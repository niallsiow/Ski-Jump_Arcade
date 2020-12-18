using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    Rigidbody myRigidbody;

    public float forceAmount;

    bool start = true;


    public float jumpForce;

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
            myRigidbody.isKinematic = true;
        }
        
        Vector3 force = transform.forward * forceAmount;

        if (Input.GetButtonDown("Fire1") && start == true) {
            myRigidbody.isKinematic = false;
            start = false;
            myRigidbody.AddForce(force, ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 jumpVector = transform.up * jumpForce;
            myRigidbody.AddForce(jumpVector, ForceMode.Impulse);
        }
    }
}
