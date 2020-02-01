using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{

    AudioSource AS;

    private void Start()
    {
        AS = gameObject.GetComponent<AudioSource>();
    }

    private void Update()
    {
        if(PlayerPrefs.GetInt("Music") == 0)
        {
            AS.volume = 0;
        }
        else
        {
            AS.volume = 1;
        }

    }
}
