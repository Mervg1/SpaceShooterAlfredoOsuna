using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisilEnemigo : MonoBehaviour
{
    // Start is called before the first frame update
    private void Update()
    {
        gameObject.transform.Translate(new Vector3(.1f, 0, 0));
    }
    private void OnTriggerEnter()
    {
        Destroy(gameObject);
    }
}
