using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteoro : MonoBehaviour
{
    public float speed;

    private int life = 5;

    // Update is called once per frame
    void Update()
    {
 
        gameObject.transform.Translate(new Vector3(-.01f, 0, 0));

        if (life == 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Misil")
        {
            life--;
        }

    }
}
