using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointCounter : MonoBehaviour {

    public TextMeshProUGUI PointsLable;

	// Update is called once per frame
	void Update () {
        PointsLable.text = GameplayInputA.puntiA.ToString();
	}
}
