using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPID : MonoBehaviour {


    public int puntiD = 0;

    private void OnTriggerEnter(Collider other)
    {

        if (Input.GetKeyDown(KeyCode.S))
        {
            puntiD = puntiD + 10;
            GameObject.Destroy(other.gameObject);
        }
    }

    private void OnTriggerStay(Collider other)
    {

        if (Input.GetKeyDown(KeyCode.S))
        {
            puntiD = puntiD + 50;
            GameObject.Destroy(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (Input.GetKeyDown(KeyCode.S))
        {
            puntiD = puntiD + 10;
            GameObject.Destroy(other.gameObject);
        }
    }
}
