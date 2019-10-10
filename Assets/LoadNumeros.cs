using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNumeros : MonoBehaviour
{
    private GeradorNumerosRandom gerador;
    private StaticValue info;
    private MetodosOrdenacao ordenacao;
    private Contador contador;
    void Start()
    {
        gerador = GameObject.FindObjectOfType<GeradorNumerosRandom>();
        info = GameObject.FindObjectOfType<StaticValue>();
        ordenacao = GameObject.FindObjectOfType<MetodosOrdenacao>();
        contador = GameObject.FindObjectOfType<Contador>();
        
        gerador.gerarNumeros();
        contador.preencheBotoes();


        string metodo = info.getMetodo();

        if (metodo == "btnSelection")
        {
            ordenacao.selection();

        }
        else if (metodo == "btnInsertion")
        {
            ordenacao.insertion();

        }
        else if (metodo == "btnShell")
        {
            ordenacao.shell();

        }
        else if (metodo == "btnBubble")
        {
            ordenacao.bubble();

        }
        else if (metodo == "btnQuick")
        {
            ordenacao.quick();
        }
     }  


}
