using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNumeros2 : MonoBehaviour
{
    private GeradorNumerosRandom2 gerador;
    private StaticValue2 info;
    private MetodosOrdenacao2 ordenacao;
    //private Contador contador;
    void Start()
    {
        gerador = GameObject.FindObjectOfType<GeradorNumerosRandom2>();
        info = GameObject.FindObjectOfType<StaticValue2>();
        ordenacao = GameObject.FindObjectOfType<MetodosOrdenacao2>();
        //contador = GameObject.FindObjectOfType<Contador>();
        
        gerador.gerarNumeros();
        //contador.preencheBotoes();


        string metodo1 = info.getMetodo1();
        string metodo2 = info.getMetodo2();

        if (metodo1 == "btnSelection")
        {
            ordenacao.selection(1);

        }
        else if (metodo1 == "btnInsertion")
        {
            ordenacao.insertion(1);

        }
        else if (metodo1 == "btnShell")
        {
            ordenacao.shell(1);

        }
        else if (metodo1 == "btnBubble")
        {
            ordenacao.bubble(1);

        }
        else if (metodo1 == "btnQuick")
        {
            ordenacao.quick(1);
        }



        if (metodo2 == "btnSelection")
        {
            ordenacao.selection(2);

        }
        else if (metodo2 == "btnInsertion")
        {
            ordenacao.insertion(2);

        }
        else if (metodo2 == "btnShell")
        {
            ordenacao.shell(2);

        }
        else if (metodo2 == "btnBubble")
        {
            ordenacao.bubble(2);

        }
        else if (metodo2 == "btnQuick")
        {
            ordenacao.quick(2);
        }


    }  


}
