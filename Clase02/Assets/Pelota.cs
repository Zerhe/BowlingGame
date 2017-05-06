using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour {

    private Rigidbody rb;
    private Vector3 posInicial;
    private float velBola;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        posInicial = transform.position;
        velBola = 1;
    }
	
	void Update ()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            velBola++;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            rb.AddForce(Vector3.forward * velBola, ForceMode.Impulse);
            velBola = 1;
        }
		else if (Input.GetKey(KeyCode.D) && rb.velocity.z == 0)
        {
            rb.AddForce(Vector3.right * 100);
        }
        else if (Input.GetKey(KeyCode.A) && rb.velocity.z == 0)
        {
            rb.AddForce(Vector3.left * 100);
        }
        if (rb.velocity.z == 0)
        {
            rb.velocity = Vector3.zero;
        }
        if (Input.GetKey(KeyCode.R))
        {
            rb.MovePosition(posInicial);
            rb.angularVelocity = Vector3.zero;
            rb.velocity = Vector3.zero;
        }
    }
}
