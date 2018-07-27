using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sounddsd : MonoBehaviour {


    public Slider[] sliders;
    public test_Sound[] stuff;
	// Update is called once per frame
	void Update () {
        for (int j = 0; j < sliders.Length; j++) {
            for (int i = 0; i < stuff.Length; i++) {
                stuff[i].audio.volume = sliders[j].value;
            }
        }
	}
}
