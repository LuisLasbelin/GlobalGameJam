using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test_Questions : MonoBehaviour
{

    public string[] preguntas;

    public int index;

    public Text pregunta;

    private void Start()
    {
        NuevaPregunta();
    }

    public void NuevaPregunta()
    {
        pregunta.text = preguntas[index];
    }

}
