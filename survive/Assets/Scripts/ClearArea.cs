using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ClearArea : MonoBehaviour {

    float timeSinceLastTrigger = 0f;
    public bool hasFoundClearArea = false;

    // Update is called once per frame
    void Update () {
            timeSinceLastTrigger += Time.deltaTime;
        //Debug.Log(timeSinceLastTrigger);

            if (timeSinceLastTrigger > 3 && Time.realtimeSinceStartup > 10 && hasFoundClearArea == false)
            {
                hasFoundClearArea = true;
                
                SendMessageUpwards("OnFindClearArea");
            }        
        }

    void OnTriggerStay(Collider collider)
    {
        if (collider.tag != "Player")
        {
            timeSinceLastTrigger = 0f;
        }
    }
}


