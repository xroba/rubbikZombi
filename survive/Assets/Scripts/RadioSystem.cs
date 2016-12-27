using UnityEngine;
using System.Collections;

public class RadioSystem : MonoBehaviour {

    AudioSource audioSource;
    public AudioClip initialCallReply;
    public AudioClip initialCall;
    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
    void OnMakeInitialCallHeliCall()
    {
        Debug.Log(name + "OnMakeInitialCallHeliCall");
        audioSource.clip = initialCall;
        audioSource.Play();

        Invoke("DispatchHeli", initialCall.length + 1f);
    }

    void DispatchHeli()
    {
        audioSource.clip = initialCallReply;
        audioSource.Play();

        //in order to make moving the heli
        BroadcastMessage("OnDispatchHelicopter");
    }
}
