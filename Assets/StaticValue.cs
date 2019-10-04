using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StaticValue : MonoBehaviour
{
    static private int intervaloInicio, intervaloFim, qtd;
    static private string metodo;
    
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
        //Debug.Log(qtd);
    }

    public void lerMetodo()
    {
        metodo = EventSystem.current.currentSelectedGameObject.name;
        //Debug.Log(metodo);
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

    public string getMetodo()
    {
        return metodo;
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
