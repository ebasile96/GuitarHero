using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteDestroyer : MonoBehaviour {

    
	void OnTriggerExit(Collider collider)
    {
        if(collider.tag == "Respawn")
        GameObject.Destroy(this.gameObject);
    }

    
}
