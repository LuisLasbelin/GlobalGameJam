using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Script : MonoBehaviour
{

    Test_Botones TB;
    public int respuesta;

    SpriteRenderer sr;
    public Color resaltado, normal;

    private void Start()
    {
        TB = FindObjectOfType<Test_Botones>();

        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        TB.RecibirRespuesta(respuesta);
        // Debug.Log("Boton " + respuesta + " pulsado.");
    }

    private void OnMouseEnter()
    {
        sr.color = resaltado;
    }

    private void OnMouseExit()
    {
        sr.color = normal;
    }

}
