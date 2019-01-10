using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighScoreController : MonoBehaviour {

    public TextMeshProUGUI PointsLable;

    // Use this for initialization
    void Start () {
        setLable(PlayerPrefs.GetInt("HighScore"));
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            if (PlayerPrefs.GetInt("HighScore") > GameplayInputA.puntiA)
                return;
            PlayerPrefs.SetInt("HighScore", GameplayInputA.puntiA);
            PlayerPrefs.Save();
            PointsLable.text = "HighScore: " + GameplayInputA.puntiA.ToString();
        }
	}

    void setLable(int highScore) {
        PointsLable.text = "HighScore: " + highScore.ToString();
    }
}
