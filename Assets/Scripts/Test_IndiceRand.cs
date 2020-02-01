using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_IndiceRand : MonoBehaviour
{


    public int preguntasAcertadas = 0;
    public int preguntasFalladas = 0;
    public int categorias = 5;
    public int preguntas = 50;
    public int cont = 0;


    public void contadordeAcertadas()
    {
        preguntasAcertadas++;
    }

    public void contadordeFalladas()
    {
        preguntasFalladas++;
    }

    public int calcularIndice()
    {

        int random = Random.Range(0, 49);

        for (int i = 0; i < 5; i++)
        {

            random = random - 10;

            if (random >= 0)
            {
                cont++;

                if (random - 10 < 0)
                {
                    if (random >= 5)
                    {
                        random = random - 5;
                        break;
                    }
                    break;
                }
            }
        }



        int index = cont * 10 + random + preguntasAcertadas / 10 + preguntasFalladas / 3;

        if (index >= 50)
        {
            index = 49;
        }

        return index;

    }




}
