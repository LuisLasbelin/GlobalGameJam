using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test_Answers : MonoBehaviour
{

    public Text[] botones;

    Test_Botones TB;

    public int[] correct;

    // Respuestas pregunta 0
    public string[] answers0;

    // Respuestas pregunta 1
    public string[] answers1;

    // Respuestas pregunta 2
    public string[] answers2;

    // Respuestas pregunta 3
    public string[] answers3;

    // Respuestas pregunta 4
    public string[] answers4;

    // Respuestas pregunta 5
    public string[] answers5;

    // Respuestas pregunta 6
    public string[] answers6;

    // Respuestas pregunta 7
    public string[] answers7;

    // Respuestas pregunta 8
    public string[] answers8;

    // Respuestas pregunta 9
    public string[] answers9;

    // Respuestas pregunta 10
    public string[] answers10;

    // Respuestas pregunta 11
    public string[] answers11;

    // Respuestas pregunta 12
    public string[] answers12;

    // Respuestas pregunta 13
    public string[] answers13;

    // Respuestas pregunta 14
    public string[] answers14;

    // Respuestas pregunta 15
    public string[] answers15;

    // Respuestas pregunta 16
    public string[] answers16;

    // Respuestas pregunta 17
    public string[] answers17;

    // Respuestas pregunta 18
    public string[] answers18;

    // Respuestas pregunta 19
    public string[] answers19;

    // Respuestas pregunta 20
    public string[] answers20;

    // Respuestas pregunta 21
    public string[] answers21;

    // Respuestas pregunta 22
    public string[] answers22;

    // Respuestas pregunta 23
    public string[] answers23;

    // Respuestas pregunta 24
    public string[] answers24;

    // Respuestas pregunta 25
    public string[] answers25;

    // Respuestas pregunta 26
    public string[] answers26;

    // Respuestas pregunta 27
    public string[] answers27;

    // Respuestas pregunta 28
    public string[] answers28;

    // Respuestas pregunta 29
    public string[] answers29;

    // Respuestas pregunta 30
    public string[] answers30;

    // Respuestas pregunta 31
    public string[] answers31;

    // Respuestas pregunta 32
    public string[] answers32;

    // Respuestas pregunta 33
    public string[] answers33;

    // Respuestas pregunta 34
    public string[] answers34;

    // Respuestas pregunta 35
    public string[] answers35;

    // Respuestas pregunta 36
    public string[] answers36;

    // Respuestas pregunta 37
    public string[] answers37;

    // Respuestas pregunta 38
    public string[] answers38;

    // Respuestas pregunta 39
    public string[] answers39;

    // Respuestas pregunta 40
    public string[] answers40;

    // Respuestas pregunta 41
    public string[] answers41;

    // Respuestas pregunta 42
    public string[] answers42;

    // Respuestas pregunta 43
    public string[] answers43;

    // Respuestas pregunta 44
    public string[] answers44;

    // Respuestas pregunta 45
    public string[] answers45;

    // Respuestas pregunta 46
    public string[] answers46;

    // Respuestas pregunta 47
    public string[] answers47;

    // Respuestas pregunta 48
    public string[] answers48;

    // Respuestas pregunta 49
    public string[] answers49;

    private void Start()
    {
        TB = FindObjectOfType<Test_Botones>();

        //
        // A partir de aqui se escriben las respuestas
        //

        correct[0] = 0;

        //Miscelánea

        answers0[0] = "Braille";//Correcta
        answers0[1] = "Ideograma";
        answers0[2] = "Morse";
        answers0[3] = "Jeroglífico";
        /**/
        correct[1] = 3;
        answers1[0] = "El búfalo";
        answers1[1] = "El tigre";
        answers1[2] = "El elefante";
        answers1[3] = "El león";//Correcta
        /**/
        correct[2] = 3;
        answers2[0] = "1";
        answers2[1] = "2";
        answers2[2] = "5";
        answers2[3] = "4";//Correcta
        /**/
        correct[3] = 1;
        answers3[0] = "Primavera";
        answers3[1] = "Verano";//Correcta
        answers3[2] = "Otoño";
        answers3[3] = "Invierno";
        /**/
        correct[4] = 1;
        answers4[0] = "Real Madrid";
        answers4[1] = "FC Barcelona";//Correcta
        answers4[2] = "Valencia CF";
        answers4[3] = "Sevilla FC";
        /**/
        correct[5] = 2;
        answers5[0] = "Fútbol";
        answers5[1] = "Baloncesto";
        answers5[2] = "Tenis";//Correcta
        answers5[3] = "Rugby";
        /**/
        correct[6] = 2;
        answers6[0] = "Un pez";
        answers6[1] = "Un mamífero";
        answers6[2] = "Una flor";//Correcta
        answers6[3] = "Un reptil";
        /**/
        correct[7] = 3;
        answers7[0] = "Renault";
        answers7[1] = "Toyota";
        answers7[2] = "McLaren";
        answers7[3] = "Ferrari";//Correcta
        /**/
        correct[8] = 3;
        answers8[0] = "Italia";
        answers8[1] = "España";
        answers8[2] = "Francia";
        answers8[3] = "Ciudad del Vaticano";//Correcta
        /**/
        correct[9] = 3;
        answers9[0] = "Roma";
        answers9[1] = "Milán";
        answers9[2] = "Madrid";
        answers9[3] = "París";//Correcta
        /**/

        //Geografía e historia

        /**/
        correct[10] = 1;
        answers10[0] = "Griega";
        answers10[1] = "Romana";
        answers10[2] = "Cirílica";
        answers10[3] = "Persa";
        /**/
        correct[11] = 2;
        answers11[0] = "Tokio";
        answers11[1] = "Seúl";
        answers11[2] = "Pekin";
        answers11[3] = "Hong Kong";
        /**/
        correct[12] = 2;
        answers12[0] = "Francia";
        answers12[1] = "Rusia";
        answers12[2] = "EEUU";
        answers12[3] = "Inglaterra";
        /**/
        correct[13] = 3;
        answers13[0] = "Los Alpes";
        answers13[1] = "Los Andes";
        answers13[2] = "Los Cárpatos";
        answers13[3] = "El Himalaya";
        /**/
        correct[14] = 2;
        answers14[0] = "Chicago";
        answers14[1] = "Washington";
        answers14[2] = "Nueva York";
        answers14[3] = "Los Ángeles";
        /**/
        correct[15] = 0;
        answers15[0] = "Copenhague";
        answers15[1] = "Oslo";
        answers15[2] = "Estocolmo";
        answers15[3] = "Helsinki";
        /**/
        correct[16] = 0;
        answers16[0] = "Jeroglíficos";
        answers16[1] = "Romana";
        answers16[2] = "Cirílica";
        answers16[3] = "Ebraica";
        /**/
        correct[17] = 3;
        answers17[0] = "Valencia";
        answers17[1] = "Barcelona";
        answers17[2] = "Palermo";
        answers17[3] = "París";
        /**/
        correct[18] = 2;
        answers18[0] = "Italia";
        answers18[1] = "España";
        answers18[2] = "Portugal";
        answers18[3] = "Suiza";
        /**/
        correct[19] = 0;
        answers19[0] = "Armstrong";
        answers19[1] = "Lindberg";
        answers19[2] = "Gagarino";
        answers19[3] = "Tintín";
        /**/

        //Mates

        /**/
        correct[20] = 1;
        answers20[0] = "15";
        answers20[1] = "20";
        answers20[2] = "25";
        answers20[3] = "40";
        /**/
        correct[21] = 3;
        answers21[0] = "Área";
        answers21[1] = "Volumen";
        answers21[2] = "Anchura";
        answers21[3] = "Perímetri";
        /**/
        correct[22] = 3;
        answers22[0] = "100";
        answers22[1] = "1.000";
        answers22[2] = "10.000";
        answers22[3] = "100.000";
        /**/
        correct[23] = 0;
        answers23[0] = "999";
        answers23[1] = "990";
        answers23[2] = "1001";
        answers23[3] = "9999";
        /**/
        correct[24] = 3;
        answers24[0] = "20";
        answers24[1] = "30";
        answers24[2] = "5";
        answers24[3] = "10";
        /**/
        correct[25] = 3;
        answers25[0] = "300";
        answers25[1] = "100";
        answers25[2] = "500";
        answers25[3] = "150";
        /**/
        correct[26] = 1;
        answers26[0] = "3";
        answers26[1] = "5";
        answers26[2] = "4";
        answers26[3] = "2";
        /**/
        correct[27] = 2;
        answers27[0] = "6";
        answers27[1] = "7";
        answers27[2] = "8";
        answers27[3] = "9";
        /**/
        correct[28] = 1;
        answers28[0] = "Priemero";
        answers28[1] = "Segundo";
        answers28[2] = "Tercero";
        answers28[3] = "Último";
        /**/
        correct[29] = 0;
        answers29[0] = "3h y 10 min";
        answers29[1] = "1h y 40 min";
        answers29[2] = "3h";
        answers29[3] = "2h y 50 min";
        /**/

        //Ciencia

        /**/
        correct[30] = 3;
        answers30[0] = "Raquitismo";
        answers30[1] = "Obesidad";
        answers30[2] = "Escorbuto";
        answers30[3] = "Anorexia";
        /**/
        correct[31] = 2;
        answers31[0] = "1";
        answers31[1] = "10";
        answers31[2] = "100";
        answers31[3] = "1000";
        /**/
        correct[32] = 0;
        answers32[0] = "45";
        answers32[1] = "90";
        answers32[2] = "120";
        answers32[3] = "300";
        /**/
        correct[33] = 0;
        answers33[0] = "Constructiva";
        answers33[1] = "Energética";
        answers33[2] = "Reguladora";
        answers33[3] = "Anabolizante";
        /**/
        correct[34] = 3;
        answers34[0] = "Digestivo";
        answers34[1] = "Excretor";
        answers34[2] = "Circulatorio";
        answers34[3] = "Respiratorio";
        /**/
        correct[35] = 0;
        answers35[0] = "Traslación";
        answers35[1] = "Rotación";
        answers35[2] = "Giro";
        answers35[3] = "Oscilación";
        /**/
        correct[36] = 2;
        answers36[0] = "Excretor";
        answers36[1] = "Digestivo";
        answers36[2] = "Circulatorio";
        answers36[3] = "Respiratorio";
        /**/
        correct[37] = 3;
        answers37[0] = "Digestivo";
        answers37[1] = "Circulatorio";
        answers37[2] = "Excretor";
        answers37[3] = "Respiratorio";
        /**/
        correct[38] = 2;
        answers38[0] = "300";
        answers38[1] = "345";
        answers38[2] = "366";
        answers38[3] = "365";
        /**/
        correct[39] = 1;
        answers39[0] = "Lustro";
        answers39[1] = "Década";
        answers39[2] = "Centenario";
        answers39[3] = "Milenio";
        /**/

        //Arte

        /**/
        correct[40] = 1;
        answers40[0] = "Teléfono";
        answers40[1] = "Cine";
        answers40[2] = "Automóvil";
        answers40[3] = "Electricidad";
        /**/
        correct[41] = 1;
        answers41[0] = "4";
        answers41[1] = "5";
        answers41[2] = "6";
        answers41[3] = "3";
        /**/
        correct[42] = 0;
        answers42[0] = "Verde";
        answers42[1] = "Rojo";
        answers42[2] = "Amarillo";
        answers42[3] = "Negro";
        /**/
        correct[43] = 2;
        answers43[0] = "Percusión";
        answers43[1] = "Cuerda";
        answers43[2] = "Viento-madera";
        answers43[3] = "Viento-metal";
        /**/
        correct[44] = 2;
        answers44[0] = "4";
        answers44[1] = "6";
        answers44[2] = "8";
        answers44[3] = "10";
        /**/
        correct[45] = 3;
        answers45[0] = "A color";
        answers45[1] = "Acabado";
        answers45[2] = "Feo";
        answers45[3] = "Preliminar";
        /**/
        correct[46] = 0;
        answers46[0] = "Azul";
        answers46[1] = "Verde";
        answers46[2] = "Marrón";
        answers46[3] = "Blanco";
        /**/
        correct[47] = 2;
        answers47[0] = "Actor";
        answers47[1] = "Escritor";
        answers47[2] = "Pintor";
        answers47[3] = "Músico";
        /**/
        correct[48] = 3;
        answers48[0] = "Beethoven";
        answers48[1] = "Mozart";
        answers48[2] = "Bach";
        answers48[3] = "Vivaldi";
        /**/
        correct[49] = 2;
        answers49[0] = "Batería";
        answers49[0] = "Guitarra";
        answers49[0] = "Piano";
        answers49[0] = "Flauta travesera";
        /**/

        //
        // -------------------------------------------
        //

        NuevaPregunta();
    }
    public void NuevaPregunta()
    {

        for (int i = 0; i < 4; i++)
        {
            if(TB.index == 0)
            {
                botones[i].text = answers0[i];
            }
            if (TB.index == 1)
            {
                botones[i].text = answers1[i];
            }
            if (TB.index == 2)
            {
                botones[i].text = answers2[i];
            }
            if (TB.index == 3)
            {
                botones[i].text = answers3[i];
            }
            if (TB.index == 4)
            {
                botones[i].text = answers4[i];
            }
            if (TB.index == 5)
            {
                botones[i].text = answers5[i];
            }
            if (TB.index == 6)
            {
                botones[i].text = answers6[i];
            }
            if (TB.index == 7)
            {
                botones[i].text = answers7[i];
            }
            if (TB.index == 8)
            {
                botones[i].text = answers8[i];
            }
            if (TB.index == 9)
            {
                botones[i].text = answers9[i];
            }

            if (TB.index == 10)
            {
                botones[i].text = answers10[i];
            }
            if (TB.index == 11)
            {
                botones[i].text = answers11[i];
            }
            if (TB.index == 12)
            {
                botones[i].text = answers12[i];
            }
            if (TB.index == 13)
            {
                botones[i].text = answers13[i];
            }
            if (TB.index == 14)
            {
                botones[i].text = answers14[i];
            }
            if (TB.index == 15)
            {
                botones[i].text = answers15[i];
            }
            if (TB.index == 16)
            {
                botones[i].text = answers16[i];
            }
            if (TB.index == 17)
            {
                botones[i].text = answers17[i];
            }
            if (TB.index == 18)
            {
                botones[i].text = answers18[i];
            }
            if (TB.index == 19)
            {
                botones[i].text = answers19[i];
            }

            if (TB.index == 20)
            {
                botones[i].text = answers20[i];
            }
            if (TB.index == 21)
            {
                botones[i].text = answers21[i];
            }
            if (TB.index == 22)
            {
                botones[i].text = answers22[i];
            }
            if (TB.index == 23)
            {
                botones[i].text = answers23[i];
            }
            if (TB.index == 24)
            {
                botones[i].text = answers24[i];
            }
            if (TB.index == 25)
            {
                botones[i].text = answers25[i];
            }
            if (TB.index == 26)
            {
                botones[i].text = answers26[i];
            }
            if (TB.index == 27)
            {
                botones[i].text = answers27[i];
            }
            if (TB.index == 28)
            {
                botones[i].text = answers28[i];
            }
            if (TB.index == 29)
            {
                botones[i].text = answers29[i];
            }

            if (TB.index == 30)
            {
                botones[i].text = answers30[i];
            }
            if (TB.index == 31)
            {
                botones[i].text = answers31[i];
            }
            if (TB.index == 32)
            {
                botones[i].text = answers32[i];
            }
            if (TB.index == 33)
            {
                botones[i].text = answers33[i];
            }
            if (TB.index == 34)
            {
                botones[i].text = answers34[i];
            }
            if (TB.index == 35)
            {
                botones[i].text = answers35[i];
            }
            if (TB.index == 36)
            {
                botones[i].text = answers36[i];
            }
            if (TB.index == 37)
            {
                botones[i].text = answers37[i];
            }
            if (TB.index == 38)
            {
                botones[i].text = answers38[i];
            }
            if (TB.index == 39)
            {
                botones[i].text = answers39[i];
            }

            if (TB.index == 40)
            {
                botones[i].text = answers40[i];
            }
            if (TB.index == 41)
            {
                botones[i].text = answers41[i];
            }
            if (TB.index == 42)
            {
                botones[i].text = answers42[i];
            }
            if (TB.index == 43)
            {
                botones[i].text = answers43[i];
            }
            if (TB.index == 44)
            {
                botones[i].text = answers44[i];
            }
            if (TB.index == 45)
            {
                botones[i].text = answers45[i];
            }
            if (TB.index == 46)
            {
                botones[i].text = answers46[i];
            }
            if (TB.index == 47)
            {
                botones[i].text = answers47[i];
            }
            if (TB.index == 48)
            {
                botones[i].text = answers48[i];
            }
            if (TB.index == 49)
            {
                botones[i].text = answers49[i];
            }

        }

    }

}