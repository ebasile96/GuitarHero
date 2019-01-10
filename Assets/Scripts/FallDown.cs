using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDown : MonoBehaviour {

    public float FallSpeed = 0.4f;
    public Rigidbody rb;

	// Use this for initialization
	void Start () {
        if (rb == null)
        {
            rb = GetComponent<Rigidbody>();
        }
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        FretFall();
	}

    public void FretFall()
    {
         rb.transform.position = transform.position + new Vector3(0, 0, -FallSpeed);
       // rb.AddForce(new Vector3(0, -FallSpeed, 0) * Time.deltaTime);
    }
}
