using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class manejador : MonoBehaviour
{
  public void CargarEscena (string escena)
    {
        SceneManager.LoadScene(escena);
    }

  public void Salir()
    {
        Application.Quit();
    }
}
