using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanastaControl : MonoBehaviour
{
    public float speed = 5.0f;  // Velocidad de movimiento de la canasta

    // Colores disponibles para la canasta
    public readonly Color colorRojo = Color.red;
    public readonly Color colorVerde = Color.green;
    public readonly Color colorAzul = Color.blue;

    void Start()
    {
        // Obtener el color seleccionado guardado en PlayerPrefs (default: Rojo)
        int colorIndex = PlayerPrefs.GetInt("SelectedColor", 0);
         Debug.Log("Color index from PlayerPrefs: " + colorIndex);

        // Aplicar el color seleccionado a la canasta
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            switch (colorIndex)
            {
                case 0:  // Rojo
                    renderer.material.color = colorRojo;
                    break;
                case 1:  // Verde
                    renderer.material.color = colorVerde;
                    break;
                case 2:  // Azul
                    renderer.material.color = colorAzul;
                    break;
                default:
                    Debug.LogWarning("Color no reconocido");
                    break;
            }
        }
        else
        {
            Debug.LogError("Renderer component not found on GameObject " + gameObject.name);
        }
    }

    void Update()
    {
        MoveHorizontal();
    }

    void MoveHorizontal()
    {
        // Obtener el valor del eje horizontal (teclas de flechas o A/D)
        float horizontal = Input.GetAxis("Horizontal");

        // Crear un vector de movimiento basado en la entrada del usuario
        Vector3 movement = new Vector3(horizontal, 0, 0) * Time.deltaTime * speed;

        // Aplicar el movimiento al transform del objeto que tiene este script
        transform.Translate(movement);
    }
}

