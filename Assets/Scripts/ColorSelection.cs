using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ColorSelection : MonoBehaviour
{
    public enum PlayerColor
    {
        Red,
        Green,
        Blue
    }

    private PlayerColor selectedColor = PlayerColor.Red;
    private string savePath;

    public static ColorSelection Instance { get; private set; }

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            savePath = Application.persistentDataPath + "/colorSelection.json";
            LoadColorSelection();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SelectColor(int colorIndex)
    {
        selectedColor = (PlayerColor)colorIndex;
        SaveColorSelection();
    }

    public PlayerColor GetSelectedColor()
    {
        return selectedColor;
    }

    void SaveColorSelection()
    {
        ColorSelectionData data = new ColorSelectionData();
        data.selectedColor = selectedColor;

        string jsonData = JsonUtility.ToJson(data);
        File.WriteAllText(savePath, jsonData);
    }

    void LoadColorSelection()
    {
        if (File.Exists(savePath))
        {
            string jsonData = File.ReadAllText(savePath);
            ColorSelectionData data = JsonUtility.FromJson<ColorSelectionData>(jsonData);
            selectedColor = data.selectedColor;
        }
    }

    [System.Serializable]
    private class ColorSelectionData
    {
        public PlayerColor selectedColor;
    }
}