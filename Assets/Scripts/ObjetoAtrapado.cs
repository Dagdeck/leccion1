using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 


public class ObjetoAtrapado : DestroyObjectsBase
{
    public TextMeshProUGUI textMeshPro;  // Referencia al TextMeshPro para mostrar el puntaje
    public ScoreManager scoreManager;  // Referencia al ScoreManager
    private int score = 0;  // Puntaje actual

    private void Start()
    {
    
        // Encontrar y obtener una referencia al ScoreManager en la escena
        scoreManager = FindObjectOfType<ScoreManager>();
        
    }

    // Método para destruir objetos con la etiqueta especificada
    protected override void OnTriggerEnter(Collider other)
    {
        // Llama al método de la clase base para destruir el objeto con la etiqueta especificada
        DestroyOnTag(other, "objetoCaido");

        // Incrementa el puntaje
        score++;

        // Actualiza el texto del TextMeshPro
        if (textMeshPro != null)
        {
            textMeshPro.text = "Score: " + score;
        }

        // Verifica y actualiza el puntaje máximo en ScoreManager si se supera
        if (scoreManager != null)
        {
            scoreManager.UpdateMaxScore(score);
        }
    }
}