using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Script de los textos de las respuestas

public class Test_Answers : MonoBehaviour
{

    public Text[] botones;

    Test_Botones TB;

    private void Start()
    {
        TB = FindObjectOfType<Test_Botones>();

        NuevaPregunta();
    }
    public void NuevaPregunta()
    {

        for (int i = 0; i < 4; i++)
        {
            if(TB.index == 0)
            {
                botones[i].text = answers0[i];
            }
            if (TB.index == 1)
            {
                botones[i].text = answers1[i];
            }

        }

    }

    public int[] correct;

    // Respuestas pregunta 0
    public string[] answers0;

    // Respuestas pregunta 1
    public string[] answers1;

    // Respuestas pregunta 2
    public string[] answers2;

    // Respuestas pregunta 3
    public string[] answers3;

    // Respuestas pregunta 4
    public string[] answers4;

    // Respuestas pregunta 5
    public string[] answers5;

    // Respuestas pregunta 6
    public string[] answers6;

    // Respuestas pregunta 7
    public string[] answers7;

    // Respuestas pregunta 8
    public string[] answers8;
}
