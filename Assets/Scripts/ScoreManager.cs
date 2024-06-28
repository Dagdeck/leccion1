using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class ScoreManager : MonoBehaviour
{
    private int maxScore = 0;  // Puntaje máximo inicial
    public TextMeshProUGUI textMeshPro;

    // Static instance para asegurar que solo haya una instancia del ScoreManager
    private static ScoreManager instance;
    public static ScoreManager Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        // Si no hay ninguna instancia, establece esta como la instancia actual
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // No destruir este GameObject al cargar una nueva escena
        }
        else
        {
            Destroy(gameObject); // Si ya hay una instancia, destruir esta
        }

        // Cargar el puntaje máximo almacenado (si lo hay)
        maxScore = PlayerPrefs.GetInt("MaxScore", 0);

        // Mostrar el puntaje máximo inicialmente en el TextMeshProUGUI
        if (textMeshPro != null)
        {
            UpdateTextMeshPro();
        }
    }

    // Método para actualizar el puntaje máximo si se supera
    public void UpdateMaxScore(int currentScore)
    {
        if (currentScore > maxScore)
        {
            maxScore = currentScore;
            // Guardar el nuevo puntaje máximo
            PlayerPrefs.SetInt("MaxScore", maxScore);
            PlayerPrefs.Save();  // Guardar los cambios

            // Actualizar el TextMeshProUGUI
            UpdateTextMeshPro();
        }
    }

    // Método para obtener el puntaje máximo actual
    public int GetMaxScore()
    {
        return maxScore;
    }

    // Método para actualizar el TextMeshProUGUI con el puntaje máximo
    private void UpdateTextMeshPro()
    {
        if (textMeshPro != null)
        {
            textMeshPro.text = "Max Score: " + maxScore;
        }
    }
}
