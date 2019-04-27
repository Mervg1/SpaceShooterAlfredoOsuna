using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanionEnemigo : MonoBehaviour
{
    //Drag in the Bullet Emitter from the Component Inspector.
    public GameObject Player;
    Collision col;

    public GameObject Bala;
    private GameObject Handler;

    public float velocidad;
    public float tiempoCPU = 1.5f;

   

    // Update is called once per frame
    void Update()
    {
        tiempoCPU -= Time.deltaTime;
        if (tiempoCPU<=0)
        { 
            Handler = Instantiate(Bala, Player.transform.position, Player.transform.rotation) as GameObject;

            tiempoCPU = 1.5f;
        }
    }
}
