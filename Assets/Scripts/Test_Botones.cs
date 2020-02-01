using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Guarda el indice de la pregunta y llama a las preguntas y respuestas
// Comprueba si la respuesta es la correcta

public class Test_Botones : MonoBehaviour
{

    Test_Questions TQ;
    Test_Answers TA;

    cannon_shoot cs;

    public int index;

    private void Start()
    {
        TQ = FindObjectOfType<Test_Questions>();
        TA = FindObjectOfType<Test_Answers>();

        cs = FindObjectOfType<cannon_shoot>();
    }

    public void RecibirRespuesta(int respuesta)
    {
        if(respuesta == TA.correct[index])
        {

            Debug.Log("Respuesta correcta");

            index++;
            TQ.NuevaPregunta();
            TA.NuevaPregunta();

        }
        else
        {
            Debug.Log("MAL");

            cs.Shoot();
        }
    }

}
