﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player_Life : MonoBehaviour
{

    public int health = 10;
    public int contador = 0;
    public bool barrera = false;
    public bool respuesta = false;
    public int timer = 0;//timer delta time cambiar estos
    public int winTime = 10;
    
    public void RespuestaCorrecta()
    {
        contador++;
        subirBarrera();
        youWin();

        if (contador == 3)
        {
            if (health>=10)
            {
                return;
            }
            health = health + 1;
            contador = 0;
        }

    }

    public void RespuestaMal()
    {

        if (barrera == true)
        {
            barrera = false;
            return;
        }

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
            health = 0;
            return;
        }

    }

    public void youWin()
    {

        if(timer>=winTime)
        {
            Debug.Log("You win");
            return;
        }
        timer++;

    }

}