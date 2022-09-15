using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointScript : MonoBehaviour
{

    public SpaceRocket spaceRocketScript;

    public Transform spawnpoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        print("kyllä ja kyllä osuma siellä checkpointtiin!");
        spaceRocketScript.normalSpeed = spaceRocketScript.normalSpeed * 2f;
        spaceRocketScript.boostSpeed = spaceRocketScript.boostSpeed * 2;
        //spawnpoint.position = transform.position;


    }

}
