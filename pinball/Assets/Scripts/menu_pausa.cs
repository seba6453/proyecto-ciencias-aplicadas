using System.Net.Mime;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menu_pausa : MonoBehaviour
{
    private bool pause = false;

    public GameObject panel_pausa,boton_pausa,panel_option;

    public Text porcentage_music; //porcentage de la musica ambiente

    public Text porcentage_effect; //porcentage de los sonidos de ambiente
    public Slider Music; //barra de la musica

    public Slider Effect; //Barra de los sonido de ambiente

    // Start is called before the first frame update
    void Start()
    {
        Resume();
        panel_option.SetActive(false);
        slider_music(); //inicializa la musica en la barra
        slider_effect(); //inicializa los sonidos de la barra
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume(){
        pause = false;
        panel_pausa.SetActive(false);
        boton_pausa.SetActive(true);
        Time.timeScale = 1f;
    }

    public void Pause(){
        pause = true;
        panel_pausa.SetActive(true);
        boton_pausa.SetActive(false);
        Time.timeScale = 0f;
    }

    public void option(){
        panel_option.SetActive(true);
        panel_pausa.SetActive(false);
    }

    public void option_back(){
        panel_option.SetActive(false);
        panel_pausa.SetActive(true);
    }

    public void quit(string next_scene){ //carga la escena que se le ingresa
        SceneManager.LoadScene(next_scene);
    }

    public void slider_music(){ //cambia los valores del porcentage de la barra de musica
        string texto = (Music.value).ToString() + "%";
        porcentage_music.text = texto;
    }

    public void slider_effect(){ //cambia los valores del porcentage de la barra de sonido
        string texto = (Effect.value).ToString() + "%";
        porcentage_effect.text = texto;
    }
}
