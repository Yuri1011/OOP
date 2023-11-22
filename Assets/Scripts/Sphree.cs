using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphree : Figure
{
    // INHERITANCE

    MeshRenderer cubeMR;

    void Start()
    {
        cubeMR = gameObject.GetComponent<MeshRenderer>();
        SetColor(new Color(0.0f, 0.0f, 1.0f, 1.0f)); // Устанавливаем цвет синим
        cubeMR.material.color = colorFigure;
    }

    // POLYMORPHISM

    protected override void DisplayText()
    {
        textComp.text = "Sphere Clicked!";
    }

    void OnMouseDown()
    {
        DisplayText();
        SetName();
    }

    // ENCAPSULATION

    private void SetName()
    {
        NameFigure = "SPHERE";
        Debug.Log(NameFigure);
    }
}
