using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    // Método público para cambiar de escena
    // si estamos en Menu principal, cambiar a Juego
    
    public void ChangeScene(string sceneName)
    {
        // Cargar la escena con el nombre especificado
        UnityEngine.SceneManagement.SceneManager.LoadScene("Juego");
    }
    public void ChangeScene2(string sceneName)
    {
        // Cargar la escena con el nombre especificado
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }
}

