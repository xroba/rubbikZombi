using UnityEngine;
using System.Collections;

public class Innervoice : MonoBehaviour {

    //Sound
    AudioSource audiosource;

    //AudioClip

    public AudioClip FindArea;
    public AudioClip WhatHappend;

    // Use this for initialization
    void Start () {
        audiosource = GetComponent<AudioSource>();
        audiosource.clip = WhatHappend;
        audiosource.Play();
	}
	
    void OnFindClearArea()
    {
        Debug.Log("aieaie");
        audiosource.clip = FindArea;
        audiosource.Play();

        Invoke("CallHeli", FindArea.length + 1f);
    }

    void CallHeli()
    {
        Debug.Log("callHeli form innervoice");
        SendMessageUpwards("OnMakeInitialCallHeliCall");
    }
}
