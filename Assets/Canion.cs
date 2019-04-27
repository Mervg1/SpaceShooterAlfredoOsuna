using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canion : MonoBehaviour
{

    //Drag in the Bullet Emitter from the Component Inspector.
    public GameObject Player;
    Collision col;
    
    public GameObject Bala;
    private GameObject Handler;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            
            Handler = Instantiate(Bala, Player.transform.position, Player.transform.rotation) as GameObject;


        }
    }
}