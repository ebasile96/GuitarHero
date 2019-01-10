using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour {

    public List<SpawnNote> SpawnNotes;
    public float SpawnNoteRate = 0.2f;
    public int SpawnRandomLimit = 2;

	// Use this for initialization
	void Start () {
        foreach (SpawnNote s in SpawnNotes) {
            s.spawnRate = SpawnNoteRate;
            s.randomLimit = SpawnRandomLimit;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
