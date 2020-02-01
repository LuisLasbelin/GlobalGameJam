using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Botones : MonoBehaviour
{

    Test_Questions TQ;
    Test_Answers TA;

    Player_Life PL;

    cannon_shoot cs;

    RandomIndex RI;

    public int index;

    private void Start()
    {
        TQ = FindObjectOfType<Test_Questions>();
        TA = FindObjectOfType<Test_Answers>();

        PL = FindObjectOfType<Player_Life>();

        cs = FindObjectOfType<cannon_shoot>();

        RI = FindObjectOfType<RandomIndex>();
    }

    public void RecibirRespuesta(int respuesta)
    {
        if(respuesta == TA.correct[index])
        {

            Debug.Log("Respuesta correcta");

            index = RI.generarIndiceComprobado();

            //index = Random.Range(0, 49);

            TQ.NuevaPregunta();
            TA.NuevaPregunta();

            PL.RespuestaCorrecta();

        }
        else
        {
            Debug.Log("MAL");

            cs.Shoot();
        }
    }

}
