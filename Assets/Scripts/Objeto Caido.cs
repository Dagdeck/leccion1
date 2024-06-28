using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoCaido : DestroyObjectsBase
{
    protected override void OnTriggerEnter(Collider other)
    {
        // Llamamos al método de la clase base para destruir el objeto con la etiqueta especificada
        DestroyOnTag(other, "objetoCaido");
    }
}
