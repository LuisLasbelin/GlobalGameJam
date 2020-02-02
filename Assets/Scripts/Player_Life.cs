using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player_Life : MonoBehaviour
{

    public int health = 10;
    public int contador = 0;

    public bool respuesta = false;

    public int correctas;
    public int incorrectas;
    int puntuacion;

    // Sprites de la racha
    public SpriteRenderer sr;
    public Sprite[] numeros;

    // Timer
    public float currTime = 200;

    private void Start()
    {
        currTime = 200;
    }

    public void RespuestaCorrecta()
    {
        if(contador >= 3)
        {
            contador = 4;
        }
        else
        {
            contador++;
        }

        correctas++;

        if (contador >= 3)
        {
            health = health + 1;
        }

    }

    public void RespuestaMal()
    {

        health--;

        incorrectas++;

        contador = 0;
        gameOver();
    }

    public void gameOver()
    {

        if (health <= 0)
        {
            Debug.Log("Game over");

            puntuacion = Mathf.RoundToInt(currTime);

            if (puntuacion <= 0)
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
        //
        // Condicion de victoria
        //
        if (health >= 10)
        {
            Debug.Log("You win");

            puntuacion = Mathf.RoundToInt(currTime);

            if (puntuacion <= 0)
            {
                puntuacion = 0;
            }

            PlayerPrefs.SetInt("Points", puntuacion);

            SceneManager.LoadScene(2); // Escena Victory
        }

        //
        // Contador de racha
        //
        sr.sprite = numeros[contador];

        //
        // Cuenta el tiempo
        //
        currTime -= Time.deltaTime;

    }

}