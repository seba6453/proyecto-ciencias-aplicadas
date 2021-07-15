using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class control : MonoBehaviour
{
    private AudioSource audioS;
    public static float volumen;

    public Control_luces []lucesC;
    public GameObject colisionador_fin;

    public tilt arcade;

    public Vector3 posicion_inicial;

    private Rigidbody rb;

    private int count;

    public int numero_jugadas = 3;

    public GameObject menu_final;

    public GameObject menu_pausa;

    public GameObject slider;

    public AudioClip effect;

    public Text score;

    public disparador[] disparadores;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        menu_final.SetActive(false);
        restart_ball();

        audioS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(numero_jugadas == count)
        {
            final();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        volumen = AudioSettings.audioSettings.GetSFXVolume();
        audioS.PlayOneShot(effect,volumen);

        if (collision.gameObject.name == colisionador_fin.gameObject.name) 
        {
            count +=1;
            restart_ball();
        }
    }

    private void restart_ball()
    {
        arcade.reset();
        transform.position = posicion_inicial;
        rb.velocity = new Vector3(0, 0, 0);
        for (int i = 0;i<disparadores.Length;i++)
        {
            disparadores[i].resetPared();
        }
    }

    private void final()
    {
        Time.timeScale = 0f;
        active(true);
        score.text = "Score: " + GetComponent<Marcador>().score;
    }

    private void active(bool conf)
    {
        menu_final.SetActive(conf);
        menu_pausa.SetActive(!conf);
        slider.SetActive(!conf);
    }

    public void button_restart()
    {
        active(false);
        Time.timeScale = 1f;
        count = 0;
        restart_ball();
        GetComponent<Marcador>().score = 0;
        for (int i = 0;i < lucesC.Length;i++)
        {
            lucesC[i].reset();
        }
    }

    public void button_main_menu(string next_scene)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(next_scene);
    }

    public void reset_ball()
    {
        restart_ball();
    }
}
