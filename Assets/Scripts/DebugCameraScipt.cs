using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugCameraScipt : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;
    public GameObject ui;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            cam1.enabled = false;
            cam2.enabled = true;
            ui.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            cam1.enabled = true;
            cam2.enabled = false;
            ui.SetActive(true);
        }
    }
}
