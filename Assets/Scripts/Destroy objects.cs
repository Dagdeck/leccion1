using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DestroyObjectsBase : MonoBehaviour
{
  protected void DestroyOnTag(Collider other, string tagToDestroy)
    {
        if (other.gameObject.CompareTag(tagToDestroy))
        {
            Destroy(other.gameObject);
        }
    }

    // Método que se llama cuando otro objeto entra en el trigger collider
    protected virtual void OnTriggerEnter(Collider other)
    {
        // Implementación base vacía, las clases derivadas pueden sobrescribir este método
    }
}
