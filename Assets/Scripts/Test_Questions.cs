using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test_Questions : MonoBehaviour
{

    public string[] preguntas;

    public Text pregunta;

    Test_Botones TB;

    private void Start()
    {
        TB = FindObjectOfType<Test_Botones>();

        //
        // A partir de aquí se definen las preguntas
        //


        //Miscelánea

        preguntas[0] =  "¿Cómo se llama la escritura utilizada por personas ciegas?";
        preguntas[1] =  "¿Quién se dice que es el rey de la selva?";
        preguntas[2] =  "¿Cuántas estaciones tiene el año?";
        preguntas[3] =  "¿En qué estación los días son más largos que las noches?";
        preguntas[4] =  "¿En qué equipo de Fútbol juega Leo Messi?";
        preguntas[5] =  "¿Qué deporte está relacionado a Roger Federer?";
        preguntas[6] =  "¿Qué es una orquídea?";
        preguntas[7] =  "¿En qué equipo de Formula 1 corría Michael Schumacher?";
        preguntas[8] =  "¿En qué ciudad se encuentra el museo del Louvre?";
        preguntas[9] =  "¿En qué país encontraremos la Basílica de San Pedro ?";

        //Geografía e Historia

        preguntas[10] =  "¿Cuál era la nacionalidad de Julio Cesar?";
        preguntas[11] =  "¿Cuál es la capital de China?";
        preguntas[12] =  "¿Abraham Lincoln fue presidente de qué país?";
        preguntas[13] =  "¿En qué cadena montañosa encontramos la cima más alta del mundo?";
        preguntas[14] =  "¿Dónde podemos encontrar la Estatua de la Libertad?";
        preguntas[15] =  "¿Cuál es la capital de Dinamarca?";
        preguntas[16] =  "¿Cómo se conoce a la escritura del Antiguo Egipto?";
        preguntas[17] =  "¿Cuál de las siguientes ciudades no tiene mar?";
        preguntas[18] =  "¿Qué país de los siguientes no hace frontera con Francia?";
        preguntas[19] =  "¿Qué hombre puso por primera vez el pie en la Luna?";

        //Mates

        preguntas[20] = "¿Cuál es el resultado de 5 * 3 + 5 ?";
        preguntas[21] = "¿Cómo se llama la suma de los lados de un polígono?";
        preguntas[22] = "¿A cuántas unidades equivale 10 decenas de millar?";
        preguntas[23] = "¿Cuál es el número anterior a 1000 ?";
        preguntas[24] = "Un perro pesa 20 kilos y un cachorro pesa 10 kilos menos que él, ¿cuánto pesa la cría?";
        preguntas[25] = "¿Qué distancia recorrerá un coche en tres horas si va a 50 Km / h ?";
        preguntas[26] = "¿Qué cantidad expresa el número romano 'V'?";
        preguntas[27] = "¿Qué número resulta si divides 56 entre 7 ?";
        preguntas[28] = "¿Si en una carreda adelantas al segundo, en qué posición vas ahora?";
        preguntas[29] = "¿Cuál es el resultado de sumar una 1 hora y 40 minutos y 1 hora y 30 minutos?";

        //Ciencia

        preguntas[30] =  "¿Cuál de estas es una enfermedad mental relacionada con la nutrición?";
        preguntas[31] =  "¿A cuántos centímetros equivale un metro?";
        preguntas[32] =  "¿Cuántos grados tiene un ángulo llano?";
        preguntas[33] =  "¿Qué función tienen las proteinas?";
        preguntas[34] =  "¿A qué aparato pertenece la Tráquea?";
        preguntas[35] =  "¿Cómo se llama el movimiento quue hace la Tierra alrededor del Sol?";
        preguntas[36] =  "¿A qué aparato pertenecen las venas?";
        preguntas[37] =  "¿Qué aparato se encarga de recoger oxígeno?";
        preguntas[38] =  "¿Cuántos días tiene un año bisiesto?";
        preguntas[39] =  "¿Cómo se denomina a un periodo de 10 años?";

        //Arte

        preguntas[40] =  "¿Qué inventaron los hermanos Lumière?";
        preguntas[41] =  "¿Cuántas líneas tiene un pentagrama?";
        preguntas[42] =  "¿Cuáles son los colores fríos? Azul, Violeta y...";
        preguntas[43] =  "¿Qué tipo de instrumento pertenece la flauta dulce?";
        preguntas[44] =  "¿ A cuántas corcheas equivale una redonda ?";
        preguntas[45] =  "¿Qué es un boceto? Un dibujo...";
        preguntas[46] = "¿Cuáles son los colores primarios? Amarillo, Rojo y...";
        preguntas[47] =  "¿Qué era Pablo Picasso?";
        preguntas[48] =  "¿Quién compuso 'Las cuatro estaciones' ?";
        preguntas[49] =  "¿Qué instrumento tocaba Mozart?";

        //
        // -------------------------------------------
        //

        NuevaPregunta();
    }

    public void NuevaPregunta()
    {
        pregunta.text = preguntas[TB.index];
    }

}
