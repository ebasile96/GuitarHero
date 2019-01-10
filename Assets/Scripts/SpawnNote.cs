using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNote : MonoBehaviour {

    public GameObject prefab1, prefab2, prefab3, prefab4, prefab5;
    public float spawnRate = 2f;
    float nextSpawn = 0f;
    int whatToSpawn;

    public int randomLimit = 2;

    private void Start() {
        nextSpawn = spawnRate;
    }

    void Update ()
    {
        nextSpawn = nextSpawn - Time.deltaTime;

        if (nextSpawn <= 0)
        {
            whatToSpawn = Random.Range(1, randomLimit + 1);

            switch (whatToSpawn) {
                case 1:
                    Instantiate(prefab1, transform.position, Quaternion.identity);
                    break;
                default:
                    break;
            }

            //switch (whatToSpawn)
            //{
            //    case 1:
            //        Instantiate(prefab1, transform.position, Quaternion.identity);
            //        break;
            //    case 2:
            //        Instantiate(prefab1, transform.position, Quaternion.identity);
            //        break;
            //    case 3:
            //        Instantiate(prefab1, transform.position, Quaternion.identity);
            //        break;
            //    case 4:
            //        Instantiate(prefab1, transform.position, Quaternion.identity);
            //        break;
            //    case 5:
            //        Instantiate(prefab1, transform.position, Quaternion.identity);
            //        break;
            //}
            nextSpawn = spawnRate;
        }
    }
	

}
