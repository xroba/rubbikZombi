using UnityEngine;
using System.Collections;

public class Helicopter : MonoBehaviour {

    bool isCalled;
    Rigidbody rigidbody;
	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();
        isCalled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnDispatchHelicopter()
    {
        if (!isCalled)
        {
            rigidbody.velocity = new Vector3(0, 0, 50f);
            isCalled = true;
        }
    }
}
