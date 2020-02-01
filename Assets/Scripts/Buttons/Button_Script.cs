using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Script : MonoBehaviour
{
    public AudioSource AS;

    public AudioClip click;

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
        if (PlayerPrefs.GetInt("VFX") == 1)
        {
            AS.clip = click;
            AS.Play();
        }
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
