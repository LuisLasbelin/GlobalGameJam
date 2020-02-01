using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options_Button : MonoBehaviour
{

    public AudioSource AS;

    public AudioClip click;

    public Color resaltado, normal;

    SpriteRenderer sr;

    public Animator anim;

    private void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();

        anim.SetBool("Show", true);
    }

    private void OnMouseDown()
    {
        anim.SetBool("Show", false);
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
