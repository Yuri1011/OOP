using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Figure
{
    // INHERITANCE

    MeshRenderer cubeMR;

    void Start()
    {
        cubeMR = gameObject.GetComponent<MeshRenderer>();
        SetColor(new Color(0.0f, 1.0f, 0.0f, 1.0f)); // Устанавливаем цвет зеленым
        cubeMR.material.color = colorFigure;
    }

    // POLYMORPHISM

    protected override void DisplayText()
    {
        textComp.text = "Capsule Clicked!";
    }

    void OnMouseDown()
    {
        DisplayText();
    }
}
