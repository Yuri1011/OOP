using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Figure
{
    // INHERITANCE

    MeshRenderer cubeMR;
    void Start()
    {
        cubeMR = gameObject.GetComponent<MeshRenderer>();
        SetColor(new Color(1.0f, 0.0f, 0.0f, 1.0f)); // Устанавливаем цвет красным
        cubeMR.material.color = colorFigure;
    }

    // POLYMORPHISM

    protected override void DisplayText()
    {
        textComp.text = "Cube Clicked!";
    }

    void OnMouseDown()
    {
        DisplayText();
        SetName();
    }

    // ENCAPSULATION

    private void SetName()
    {
        NameFigure = "CUBE";
        Debug.Log(NameFigure);
    }
}
