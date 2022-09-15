using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{
    public AudioSource myAudio;
    public AudioClip collectSound;
    public GameObject pickUpEffect;
    public GameManager gameManagerScript;

    private void Start()
    {
        gameManagerScript = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
        Instantiate(pickUpEffect, transform.position, transform.rotation);
        Destroy(gameObject);
        gameManagerScript.AddScore();
        }
    }
}
