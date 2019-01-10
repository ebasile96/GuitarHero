using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoodController : MonoBehaviour {

    public TextMeshProUGUI PointsLable;

    // Update is called once per frame
    void Update() {
        PointsLable.text = GameplayInputA.MoodValue.ToString();
    }
}
