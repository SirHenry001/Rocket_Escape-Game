using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript2 : MonoBehaviour
{
    public float speed;
    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.right * speed * Time.deltaTime);
        timer += Time.deltaTime;

        if (timer > 1f)
        {
            speed = -speed;
            timer = 0f;
        }

    }
}
