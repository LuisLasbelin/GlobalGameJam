using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicActive_Button : MonoBehaviour
{

    public AudioSource AS;

    public AudioClip click;

    public Color resaltado, normal;

    SpriteRenderer sr;

    public Sprite on, off;

    public bool active;

    private void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        if (active == true)
        {
            PlayerPrefs.SetInt("Music", 0);
            sr.sprite = off;

            active = false;
        }
        else
        {
            PlayerPrefs.SetInt("Music", 1);
            sr.sprite = on;

            active = true;
        }

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
