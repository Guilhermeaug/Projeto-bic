using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : Pai
{

    public RectTransform ParentPanel;
   

    private float tempo = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

   


    void trocarCorTodos(Button[] botoes)
    {
        foreach (Button x in botoes)
        {

            x.GetComponent<Image>().color = Color.white;


        }
    }


    public void bubble()
    {
        Button[] botoes = pegaArray(ParentPanel);


        //Button aux = null;

        Button botaoA = null;
        Button botaoB = null;


        for (int i = 0; i < botoes.Length; i++)
        {


            foreach (Button x in botoes)
            {

                if (botaoA == null)
                {
                    botaoA = x;
                }
                else if (botaoA != null && botaoB == null)
                {
                   
                    botaoB = x;
                  

                    tempo = tempo + 2;
                    StartCoroutine(colorir(tempo, x.GetComponent<Image>(), botaoA.GetComponent<Image>()));

                    tempo = tempo + 2;
                    StartCoroutine(comparar(tempo, botaoA, botaoB));


                }
                else if (botaoA != null && botaoB != null)
                {
                    botaoA = botaoB;
                    botaoB = x;

                    tempo = tempo + 2;
                    StartCoroutine(colorir(tempo, x.GetComponent<Image>(), botaoA.GetComponent<Image>()));

                    tempo = tempo + 2;
                    StartCoroutine(comparar(tempo, botaoA, botaoB));
                }





            }

            //Debug.Log("TROCANDO COR DE TODOS");
            botaoA = null;
            botaoB = null;
            //trocarCorTodos(botoes);
        }
    }

   
    /*
    Button[] pegaArray()
    {
        Button[] botoes = ParentPanel.GetComponentsInChildren<Button>();

        return botoes;
    }*/


    IEnumerator comparar(float tempo, Button a, Button b)
    {

        Text txtBotaoA = null;
        Text txtBotaoB = null;
        string aux;

        yield return new WaitForSecondsRealtime(tempo);
        txtBotaoA = a.GetComponentInChildren<Text>();
        txtBotaoB = b.GetComponentInChildren<Text>();


        if (int.Parse(txtBotaoB.text) < int.Parse(txtBotaoA.text))
        {
            aux = txtBotaoA.text;
            txtBotaoA.text = txtBotaoB.text;
            txtBotaoB.text = aux;
        }




        a.GetComponent<Image>().color = Color.green;

        b.GetComponent<Image>().color = Color.green;
    }

    
    IEnumerator colorir(float tempo, Image a, Image b)
    {

        yield return new WaitForSecondsRealtime(tempo);
        a.color = Color.cyan;
        b.color = Color.cyan;
    }


    IEnumerator compararDois(float tempo)
    {
        Debug.Log(Time.time);
        yield return new WaitForSecondsRealtime(tempo);
        Debug.Log(Time.time);
    }

}
