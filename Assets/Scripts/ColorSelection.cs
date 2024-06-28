using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSelection : MonoBehaviour
{
    public enum PlayerColor
    {
        Red,
        Green,
        Blue
    }

    private PlayerColor selectedColor = PlayerColor.Red;  // Color seleccionado inicialmente

    // Método para seleccionar un color y asignarlo al botón correspondiente
    public void SelectColor(int colorIndex)
    {
        selectedColor = (PlayerColor)colorIndex;

        // Guardar la selección de color en PlayerPrefs
        PlayerPrefs.SetInt("SelectedColor", (int)selectedColor);
        PlayerPrefs.Save();
    }

    // Método para obtener el color seleccionado
    public PlayerColor GetSelectedColor()
    {
        // Obtener el color seleccionado de PlayerPrefs (default: Rojo)
        int colorIndex = PlayerPrefs.GetInt("SelectedColor", (int)PlayerColor.Red);
        return (PlayerColor)colorIndex;
    }
}
