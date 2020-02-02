using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowHighScore : MonoBehaviour
{

    Text texto;

    private void Start()
    {
        texto = gameObject.GetComponent<Text>();

        texto.text = PlayerPrefs.GetInt("HighScore").ToString();
    }
}
