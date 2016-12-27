using UnityEngine;
using System.Collections;

public class eye : MonoBehaviour {

    Transform OrignalView;
    Camera eyes;
    public bool zooming = false;
    float originalFOV;
    // Use this for initialization
    void Start () {
        eyes = GetComponent<Camera>();
        originalFOV = eyes.fieldOfView;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("zoom")){
            ZoomEye();
        }
        else if (Input.GetButtonUp("zoom")){ 
            ZoomEyeBack();
        }
	}

    public void ZoomEye()
    {
        eyes.fieldOfView = originalFOV * 0.5f;
    }

    public void ZoomEyeBack()
    {
        eyes.fieldOfView = originalFOV;
    }
}
