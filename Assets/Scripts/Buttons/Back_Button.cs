using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back_Button : MonoBehaviour
{
    public AudioSource AS;

    public AudioClip click;

    public Color resaltado, normal;

    SpriteRenderer sr;

    public Animator anim;

    private void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        anim.SetBool("Show", true);
        if(PlayerPrefs.GetInt("VFX") == 1)
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
