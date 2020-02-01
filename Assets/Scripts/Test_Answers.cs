using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test_Answers : MonoBehaviour
{

    public Text[] botones;

    Test_Botones TB;

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

    private void Start()
    {
        TB = FindObjectOfType<Test_Botones>();

        //
        // A partir de aqui se escriben las respuestas
        //
        correct[0] = 0;
        answers0[0] = "Azul";
        answers0[1] = "Rojo";
        answers0[2] = "Verde";
        answers0[3] = "Amarillo";

        //
        // -------------------------------------------
        //

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


}
