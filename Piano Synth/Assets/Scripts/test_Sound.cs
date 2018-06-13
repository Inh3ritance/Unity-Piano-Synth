using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_Sound : MonoBehaviour
{
    private Renderer rendered;
    public AudioSource audio;
    public KeyCode userKey;
    private bool audioPlays;

    // Use this for initialization
    void Start()
    {
        // get component == new
        audio = GetComponent<AudioSource>();
        rendered = GetComponent<Renderer>();

    }
    // Update is called once per frame
    // outside of user control
    void Update()
    {
        if (Input.GetKeyDown(userKey))
        {
            if (!audio.isPlaying)
            {
                audio.Play();
                rendered.material.color = Color.red;
            }
        }
        else if(Input.GetKeyUp(userKey))
        {
            rendered.material.color = Color.white;
            audio.Stop();
        }
    }
}