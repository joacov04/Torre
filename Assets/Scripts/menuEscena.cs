using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuEscena : MonoBehaviour
{
    public void cambiarEscena(string nombreEscena){
        SceneManager.LoadScene(nombreEscena);
    }

    public void salirJuego(){
        Application.Quit();
        Debug.Log("Se salio del juego");
    }

}
