using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Figure : MonoBehaviour
{
    protected Color colorFigure; 

    void Start()
    {
        colorFigure = new Color();
    }

    protected virtual void SetColor(Color newColor)
    {
        colorFigure = newColor;
    }
}
