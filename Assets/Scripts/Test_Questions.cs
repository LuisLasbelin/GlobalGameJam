using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test_Questions : MonoBehaviour
{

    public string[] preguntas;

    public Text pregunta;

    Test_Botones TB;

    private void Start()
    {
        TB = FindObjectOfType<Test_Botones>();

        //
        // A partir de aquí se definen las preguntas
        //

        preguntas[0] = "¿Cuál es un color frío?";

        //
        // -------------------------------------------
        //

        NuevaPregunta();
    }

    public void NuevaPregunta()
    {
        pregunta.text = preguntas[TB.index];
    }

}
