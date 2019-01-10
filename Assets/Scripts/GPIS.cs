using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPIS : MonoBehaviour {

    public int puntiS = 0;

    private void OnTriggerEnter(Collider other)
    {

        if (Input.GetKeyDown(KeyCode.S))
        {
            puntiS = puntiS + 10;
            GameObject.Destroy(other.gameObject);
        }
    }

    private void OnTriggerStay(Collider other)
    {

        if (Input.GetKeyDown(KeyCode.S))
        {
            puntiS = puntiS + 50;
            GameObject.Destroy(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (Input.GetKeyDown(KeyCode.S))
        {
            puntiS = puntiS + 10;
            GameObject.Destroy(other.gameObject);
        }
    }
}
