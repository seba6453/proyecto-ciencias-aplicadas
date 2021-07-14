using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menu_inicio : MonoBehaviour
{
    public GameObject panel1; //inicio
    public GameObject panel2; //sonido

    public GameObject panel3; //niveles
    public GameObject panel4; //ranking

    public Text porcentage_music; //porcentage de la musica ambiente

    public Text porcentage_effect; //porcentage de los sonidos de ambiente
    public Slider Music; //barra de la musica

    public Slider Effect; //Barra de los sonido de ambiente

    void Start()
    {
        panel1.SetActive(true);
        panel2.SetActive(false);
        panel3.SetActive(false);
        panel4.SetActive(false);
        slider_music(); //inicializa la musica en la barra
        slider_effect(); //inicializa los sonidos de la barra
    }
    public void nextScene(string next_scene){ //carga la escena que se le ingresa
        SceneManager.LoadScene(next_scene);
    }

    public void option(){ //ingresa a la seccion de opciones
        panel1.SetActive(false);
        panel2.SetActive(true);
    }

    public void slider_music(){ //cambia los valores del porcentage de la barra de musica
        string texto = (Music.value).ToString() + "%";
        porcentage_music.text = texto;
    }

    public void slider_effect(){ //cambia los valores del porcentage de la barra de sonido
        string texto = (Effect.value).ToString() + "%";
        porcentage_effect.text = texto;
    }

    public void option_back(){ //vuelve al menu inicial desde las opciones
        panel1.SetActive(true);
        panel2.SetActive(false);
    }

    public void start_back(){ //vuelve al menu inicial desde los niveles
        panel1.SetActive(true);
        panel3.SetActive(false);
    }

    public void back_rank(){ //vuelve al menu inicial desde el ranking
        panel1.SetActive(true);
        panel4.SetActive(false);
    }

    public void start_rank(){
        panel4.SetActive(true);
        panel1.SetActive(false);
    }

    public void play(){ //ingresa a los niveles
        panel1.SetActive(false);
        panel3.SetActive(true);
    }

    public void exit(){ //cierra el juego
        Application.Quit();
    }
}
