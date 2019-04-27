using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameMaster : MonoBehaviour
{
    public GameObject Player;
    public GameObject CPU;
    private GameObject CloneCPU;
    public GameObject Meteoro;
    private GameObject MeteoroClon;
    public static GameMaster instance = null;
    public Text vidasJugador;
    public GameObject gameOver;
    public float tiempoMeteoro = 2f;
    public float tiempoCPU = 4f;

    private int PlayerLifes = 5;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempoMeteoro -= Time.deltaTime;
        tiempoCPU -= Time.deltaTime;
        if (tiempoMeteoro <= 0f)
        {
            MeteoroClon = Instantiate(Meteoro, new Vector3(6.76f, Random.Range(-5, 5), 0f), transform.rotation) as GameObject;
            tiempoMeteoro = 2f;
        }
        if (tiempoCPU <= 0)
        {
            CloneCPU = Instantiate(CPU, new Vector3(6.76f, Random.Range(-5, 5), 0f), transform.rotation) as GameObject;
            tiempoCPU = 4f;
        }
        if (PlayerLifes == 0)
        {
            Time.timeScale = 1;
            gameOver.SetActive(true);
        }
    }
    public void VidasJugador()
    {
        PlayerLifes--;

        vidasJugador.text = "Vidas: " + PlayerLifes;


    }
}
