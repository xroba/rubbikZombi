using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public GameObject SpawnRoot;
    Transform[] arrSpawn;
    public bool lastRespawnToogle;
    bool lastToggle;
    public GameObject LandingArea;

    // Use this for initialization
    void Start () {
        //get the spawnPoints
        arrSpawn = SpawnRoot.GetComponentsInChildren<Transform>();
        SpawnPlayer();
    }
	
    void Update()
    {
        if(lastToggle != lastRespawnToogle)
        {

            lastToggle = lastRespawnToogle;
            SpawnPlayer();
        }

        if (Input.GetButtonDown("callheli"))
        {


            //innervoice.clip = callHeli;
            //innervoice.Play();
            //helicopter.CallHeli();
        }

    }

    public void SpawnPlayer()
    {
        int spawnPoint =  Random.Range(1, arrSpawn.Length);
       // Debug.Log("Spawn = " + spawnPoint);
        Transform selectSpawn = arrSpawn[spawnPoint];


        this.gameObject.transform.position = new Vector3(selectSpawn.position.x, selectSpawn.position.y, selectSpawn.position.z); 
    
    }

    void OnFindClearArea()
    {
        Invoke("DropFlare", 3f); 
    }

    void DropFlare()
    {
        //Drop a flare
        Instantiate(LandingArea, this.transform.position, transform.rotation);
    }

}
