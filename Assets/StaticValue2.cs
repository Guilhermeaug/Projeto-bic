using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StaticValue2 : MonoBehaviour
{
    static private int intervaloInicio, intervaloFim, qtd;
    static private string metodo1, metodo2;
    //static int comparacoesSelection = 0, comparacoesInsertion = 0, comparacoesShell = 0, comparacoesBubble = 0, comparacoesQuick = 0;
    //static int trocasSelection = 0, trocasInsertion = 0, trocasShell = 0, trocasBubble = 0, trocasQuick = 0;
    static int[] comparacoes = new int[5];
    static int[] trocas = new int[5];

    
    public void lerIntervaloInicio(string alvo)
    {
        intervaloInicio = int.Parse(alvo);
        //Debug.Log(intervaloInicio);
    }

    public void lerIntervaloFim(string alvo)
    {
        intervaloFim = int.Parse(alvo);
        //Debug.Log(intervaloFim);
    }

    public void lerQuantidade(string alvo)
    {
        qtd = int.Parse(alvo);

        if(qtd > 20)
        {
            qtd = 20;
        }


        //Debug.Log(qtd);
    }

    public void lerMetodo()
    {
        if (string.IsNullOrEmpty(metodo1))
        {
            metodo1 = EventSystem.current.currentSelectedGameObject.name;
        }
        else if (string.IsNullOrEmpty(metodo2))
        {
            metodo2 = EventSystem.current.currentSelectedGameObject.name;
        }
        else
        {
            metodo1 = EventSystem.current.currentSelectedGameObject.name;
            metodo2 = "";
        }

        //Debug.Log(metodo1);
        //Debug.Log(metodo2);
    }

    public void lerOperacoes(int comp1, int comp2, int comp3, int comp4, int comp5, int troca1, int troca2, int troca3, int troca4, int troca5)
    {
        comparacoes[0] = comp1;
        comparacoes[1] = comp2;
        comparacoes[2] = comp3;
        comparacoes[3] = comp4;
        comparacoes[4] = comp5;

        

        trocas[0] = troca1;
        trocas[1] = troca2;
        trocas[2] = troca3;
        trocas[3] = troca4;
        trocas[4] = troca5;

        /*comparacoesSelection = comp1;
        comparacoesInsertion = comp2;
        comparacoesShell = comp3;
        comparacoesBubble = comp4;
        comparacoesQuick = comp5;

        trocasSelection = troca1;
        trocasInsertion = troca2;
        trocasShell = troca3;
        trocasBubble = troca4;
        trocasQuick = troca5;
        */
    }

    public int[] getComparacoes()
    {
        
        return comparacoes;
    }

    public int[] getTrocas()
    {
        return trocas;
    }

    public int getQtd()
    {
        return qtd;
    }

    public int getInicio()
    {
        return intervaloInicio;
    }

    public int getFim()
    {
        return intervaloFim;
    }

    public string getMetodo1()
    {
        return metodo1;
    }

    public string getMetodo2()
    {
        return metodo2;
    }

    /*private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log(intervaloInicio);
            Debug.Log(intervaloFim);
            Debug.Log(qtd);
            Debug.Log(metodo);
        }
    }*/

}
