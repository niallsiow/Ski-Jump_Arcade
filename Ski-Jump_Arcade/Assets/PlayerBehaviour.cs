using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    Rigidbody myRigidbody;

    float forceAmount = 10;


    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 force = transform.forward * forceAmount;

        if (Input.GetButtonDown("Fire1")) {
            myRigidbody.AddForce(force, ForceMode.Impulse);
        }
    }
}
