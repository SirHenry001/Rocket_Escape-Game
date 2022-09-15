using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceRocket : MonoBehaviour
{
    public float speed = 1f;
    public float normalSpeed = 1f;
    public float boostSpeed = 8f;

    public bool attached = false;
    public GameObject fire;

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * hor * boostSpeed * 4f * Time.deltaTime);
        
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        transform.position = new Vector3(Mathf.Clamp(transform.position.x,-24f,36f), transform.position.y, transform.position.z);

        if(Input.GetButton("Jump"))
        {
            speed = boostSpeed;
            print("spacebar");
        }

        else
        {
            speed = normalSpeed;
        }

        //if(Input.GetButtonDown("Fire1"))
        {
            //Instantiate(fire, transform.position, transform.rotation);
        }
    
      
    }
}
