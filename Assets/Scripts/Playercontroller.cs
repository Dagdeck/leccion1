using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanastaControl : MonoBehaviour
{
    public float speed = 5.0f;  // Velocidad de movimiento de la canasta
    public Renderer cubeRenderer;  // Referencia al Renderer del cubo

   void Start()
    {
       ColorSelection.PlayerColor selectedColor = ColorSelection.Instance.GetSelectedColor();
       switch (selectedColor)
        {
            case ColorSelection.PlayerColor.Red:
                cubeRenderer.material.color = Color.red;
                break;
            case ColorSelection.PlayerColor.Green:
                cubeRenderer.material.color = Color.green;
                break;
            case ColorSelection.PlayerColor.Blue:
                cubeRenderer.material.color = Color.blue;
                break;
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

