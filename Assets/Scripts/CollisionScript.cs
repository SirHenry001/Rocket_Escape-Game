using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public Transform spawnPoint;
    public GameManager gameManagerScipt;
    public SpaceRocket spaceRocketScript;

    // Game Over text and buttons
    public GameObject gameOverText;
    public GameObject retryButton;
    public GameObject quitButton;
    public GameObject explosion;

    private void OnTriggerEnter(Collider other)
    {
        print("t�rm�sin johonkin");

        if (other.gameObject.tag == "Enemy")
        {
            //transform.position = spawnPoint.position;
           // StartCoroutine(Resetplayer());
            gameManagerScipt.timer = 0f;
            spaceRocketScript.normalSpeed = 1f;
            spaceRocketScript.boostSpeed = 8f;
            gameOverText.SetActive(true);
            retryButton.SetActive(true);
            quitButton.SetActive(true);
            Instantiate(explosion, transform.position, transform.rotation);
            gameObject.SetActive(false);
        }



    }

    //harjoituskoodi siit� kuinka tuhoutumisen j�lkeen pelaaja menisi viiveell� spawnpointtiin
    //public IEnumerator Resetplayer()
    //{
        //GetComponent<Renderer>().enabled = false;
        //yield return new WaitForSeconds(2f);
        //transform.position = spawnPoint.position;
    //}
}
