using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_Button : MonoBehaviour
{

    public AudioSource AS;

    public AudioClip click;

    public Color resaltado, normal;

    SpriteRenderer sr;

    private void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        if (PlayerPrefs.GetInt("VFX") == 1)
        {
            AS.clip = click;
            AS.Play();
        }
        SceneManager.LoadScene(1); // Escena Main 
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
