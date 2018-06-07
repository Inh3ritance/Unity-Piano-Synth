using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_Sound : MonoBehaviour {

    public AudioSource audio;
    public KeyCode userKey;

	// Use this for initialization
	void Start () {
        // get component == new
        audio = GetComponent<AudioSource>();

    }
    // user updates
    void FixedUpdate()
    {
        if (Input.GetKeyDown(userKey))
        {
            audio.Play();
            //audio.Play(44100);
        }
    }
    // Update is called once per frame
    // outside of user control
    void Update () {
		
	}
}
