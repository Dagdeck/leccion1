using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generadordeobjetos : MonoBehaviour
{
    // Objeto a generar
    public GameObject objeto;

    // Límites del área de generación de objetos
    public float limiteX = 8.0f;
    public float limiteY = 4.0f;

    // Update se llama una vez por frame
    void Update()
    {
        // Generar objetos aleatorios en el rango de la pantalla al presionar la tecla de espacio
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Generar una posición aleatoria dentro de los límites especificados
            float x = Random.Range(-limiteX, limiteX);
            float y = Random.Range(-limiteY, limiteY);
            Vector3 posicion = new Vector3(x, 8, 0);

            // Instanciar el objeto en la posición aleatoria con la rotación por defecto
            Instantiate(objeto, posicion, Quaternion.identity);
        }
    }
}
