﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Script : MonoBehaviour
{

    Test_Botones TB;
    public int respuesta;

    private void Start()
    {
        TB = FindObjectOfType<Test_Botones>();
    }

    private void OnMouseDown()
    {
        TB.RecibirRespuesta(respuesta);
        // Debug.Log("Boton " + respuesta + " pulsado.");
    }

}