using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    float fMinX = -4f;
    public float velocidad;
    float fMaxX = 4f;
    int direccion = -1;
    Vector3 pisicionInicial;
    private int life = 3;
    // Start is called before the first frame update

    // Update is called once per frame
    void Start()
    {
        pisicionInicial = transform.position;
        direccion = -1;

    }
    void Update()
    {
        if (life == 0)
        {
            Destroy(gameObject);
        }

        switch (direccion)
        {
            case -1:

                if (transform.position.y > fMinX)
                {
                    gameObject.transform.Translate(new Vector3(-velocidad, -velocidad, 0)); ;
                }
                else
                {
                    direccion = 1;
                }
                break;
            case 1:
                //Moving Right
                if (transform.position.y < fMaxX)
                {
                    gameObject.transform.Translate(new Vector3(-velocidad, velocidad, 0));
                }
                else
                {
                    direccion = -1;
                }
                break;
        }

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Misil")
        {
            life--;
        }
    }
}
