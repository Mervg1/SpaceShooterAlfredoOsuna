using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Misil : MonoBehaviour
{
    // Start is called before the first frame update
    private void Update()
    {
        gameObject.transform.Translate(new Vector3(.1f, 0, 0));
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag != "Jugador")
        {
            Destroy(gameObject);
        }

    }
   
}
