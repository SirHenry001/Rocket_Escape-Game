using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public GameObject winText;
    public GameObject retryButton;
    public GameObject quitButton;

    public GameManager gm;
    private void OnTriggerEnter(Collider other)
    {
        winText.SetActive(true);
        retryButton.SetActive(true);
        quitButton.SetActive(true);
        gm.gameEnd = true;
        gm.TimeRecorder();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
