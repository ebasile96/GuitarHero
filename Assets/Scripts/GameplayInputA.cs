using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayInputA : MonoBehaviour {

    public static int puntiA = 0;
    public static float MoodValue = 0.5f;

    public float MalusValue = -0.2f;
    public float BonusValue = 0.2f;

    public KeyCode currentKeycode;

    private void Start()
    {
        
    }

	private void OnTriggerEnter(Collider other)
    {
        
        if (Input.GetKeyDown(currentKeycode))
        {
            puntiA = puntiA + 10;
            
            GameObject.Destroy(other.gameObject, 0.0f);

            MoodValue = MoodValue + BonusValue;
            if (MoodValue > 1) {
                MoodValue = 1;
            }
        }

    }
    
    private void OnTriggerStay(Collider other)
    {
        
        if (Input.GetKeyDown(currentKeycode))
        {
            puntiA = puntiA + 50;
           
            GameObject.Destroy(other.gameObject, 0.0f);

            MoodValue = MoodValue + (BonusValue * 2);
            if (MoodValue > 1) {
                MoodValue = 1;
            }

        }

    }

    private void OnTriggerExit(Collider other)
    {
        MoodValue = MoodValue + MalusValue;
        if (MoodValue < 0)
            MoodValue = 0;
    }
}
