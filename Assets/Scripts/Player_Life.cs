using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player_Life : MonoBehaviour
{

    public int health = 10;
    public int contador = 0;
    public bool barrera = false;
    public bool respuesta = false;

    public int correctas;
    public int incorrectas;
    int puntuacion;

    public void RespuestaCorrecta()
    {
        contador++;
        subirBarrera();

        correctas++;

        if (contador == 3)
        {
            if (health >= 10)
            {
                barrera = true;
            }
            else
            {
                health = health + 1;
                contador = 0;
            }
            
        }

    }

    public void RespuestaMal()
    {

        if (barrera == true)
        {
            barrera = false;
            return;
        }

        incorrectas++;

        health--;
        contador = 0;
        gameOver();
    }

    public void subirBarrera()
    {

        if (health == 10)
        {
            if (contador == 3)
            {
                barrera = true;
                contador = 0;
            }
        }
    }

    public void gameOver()
    {

        if (health <= 0)
        {
            Debug.Log("Game over");

            puntuacion = correctas - incorrectas;

            if(puntuacion <= 0)
            {
                puntuacion = 0;
            }

            PlayerPrefs.SetInt("Points", puntuacion);

            health = 0;
            SceneManager.LoadScene(3); // Escena Game Over
        }

    }

    private void Update()
    {

        if (health >= 10)
        {
            Debug.Log("You win");

            puntuacion = correctas - incorrectas;

            if (puntuacion <= 0)
            {
                puntuacion = 0;
            }

            PlayerPrefs.SetInt("Points", puntuacion);

            SceneManager.LoadScene(2); // Escena Victory
        }

    }

}