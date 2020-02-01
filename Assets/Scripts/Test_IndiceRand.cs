using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_IndiceRand : MonoBehaviour
{


    public int preguntasAcertadas = 0;
    public int preguntasFalladas = 0;
    public int categorias = 5;
    public int preguntas = 50;
    public int categoria = 0;
    public int[] ListaNegra = new int[50];
    public int contLista = 0;
    public int size = 0;


    public void contadordeAcertadas()
    {
        preguntasAcertadas++;
    }



    public void contadordeFalladas()
    {
        preguntasFalladas++;
    }
    // Si quieres un indice pideselo a esta funcion
    public int generarIndiceComprobado()
    {

        //Defino un index
        int index;

        do
        {
            //El bucle magico, si da true se devuelve, si da false se busca otro numero
            index = calcularIndice();

        } while (!comprobacion(index));

        return index;

    }

    public bool comprobacion(int index)
    {

       for (int i=0; i<50; i++)
        {   //Se comprueban las preguntas usadas con la nueva pregunta
            if(ListaNegra[i]==index)
            {
                return false;
            }           
        }
        //Se guarda la nueva pregunta en la lista Negra
        ListaNegra[size] = index;
        size++;
        return true;

    }



    public int calcularIndice()
    {

        //Se busca un numero random desde el 0 hasta el 49
        int index = Random.Range(0, 49);
        
        for(int i=0; i<5; i++)
        {

            //Comprobacion para que no pasen numeros negativos
            if(index-10<=0) {
                index = index + 10;
                break;
            }
            //Aqui se define la categoria a la que pertenece la pregunta
            index = index - 10;
            categoria++;
            //El limite se encuentra cuando indice va a entrar en los numeros negativos
            if (index - 10 <= 0){


                //algoritmo de randomizacion
                index = index + 10 * categoria + preguntasAcertadas / 10 + preguntasFalladas / 3;
                break;
            }
        }


        //prevencion de valores mayores o iguales a las preguntas totales
        if (index >= 50)
        {

            index = Random.Range(0, 49);

        }
        //prevencion de valores negativos
        else if (index<0)
        {

            index = Random.Range(0,49);

        }

        return index;
    }
}