using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frets : MonoBehaviour {

    public int position;
    public Rigidbody rb;
    public Transform RespawnPoint;

    void Awake()
    {
        if (rb==null)
        {
            rb = GetComponent<Rigidbody>(); 
        }
        
    }
    
    private void OnTriggerExit(Collider ResetTrigger)
    {
        //Debug.Log("Collision con ResetTrigger");
        transform.position = RespawnPoint.position;
        //transform.position = new Vector3(0, position, 0);
    }

}
