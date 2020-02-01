using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Textos de preguntas

public class Test_Questions : MonoBehaviour
{

    public string[] preguntas;

    public Text pregunta;

    Test_Botones TB;

    private void Start()
    {
        TB = FindObjectOfType<Test_Botones>();

        NuevaPregunta();
    }

    public void NuevaPregunta()
    {
        pregunta.text = preguntas[TB.index];
    }

}
