using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetOptions : MonoBehaviour
{

    private void Start()
    {
        PlayerPrefs.SetInt("Music", 1);
        PlayerPrefs.SetInt("SFX", 1);
    }

    public void MuteMusic()
    {
        PlayerPrefs.SetInt("Music", 0);
    }

    public void MuteVFX()
    {
        PlayerPrefs.SetInt("VFX", 0);
    }
}
