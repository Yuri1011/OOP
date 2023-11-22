using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class Figure : MonoBehaviour
{
    protected Color colorFigure; 
    Canvas Canvas;
    public TextMeshProUGUI textComp;
    protected string NameFigure{get; set;}
    void Start()
    {
        colorFigure = new Color();
        Canvas = FindObjectOfType<Canvas>();
        textComp = Canvas.GetComponentInChildren<TextMeshProUGUI>();
        DisplayText();
    }

    protected virtual void SetColor(Color newColor)
    {
        colorFigure = newColor;
    }

    protected virtual void DisplayText() {
        textComp.text = "Default Text";
    }
}
