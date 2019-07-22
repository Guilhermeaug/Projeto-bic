using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pai : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Button[] pegaArray(RectTransform ParentPanel)
    {
        Button[] botoes = ParentPanel.GetComponentsInChildren<Button>();

        return botoes;
    }

    public IEnumerator colorir(float tempo, Button a, Button b)
    {

        yield return new WaitForSecondsRealtime(tempo);
        a.GetComponent<Image>().color = Color.cyan;
        b.GetComponent<Image>().color = Color.cyan;
    }

    public IEnumerator colorir(float tempo, Button a)
    {
        yield return new WaitForSecondsRealtime(tempo);
        a.GetComponent<Image>().color = Color.cyan;
    }

    public IEnumerator troca(float tempo, Button a, Button b)
    {
        yield return new WaitForSecondsRealtime(tempo);
        a.GetComponentInChildren<Text>().text = b.GetComponentInChildren<Text>().text;
    }

    public IEnumerator troca(float tempo, Button a, int b)
    {
        yield return new WaitForSecondsRealtime(tempo);
        a.GetComponentInChildren<Text>().text = b.ToString();
    }

    public IEnumerator colorirAgain(float tempo, Button a, Button b)
    {

        yield return new WaitForSecondsRealtime(tempo);
        a.GetComponent<Image>().color = Color.white;
        b.GetComponent<Image>().color = Color.white;
    }

    public IEnumerator colorirAgain(float tempo, Button a)
    {

        yield return new WaitForSecondsRealtime(tempo);
        a.GetComponent<Image>().color = Color.white;
    }

    public IEnumerator trocaPares(float tempo, Button a, Button b)
    {
        yield return new WaitForSecondsRealtime(tempo);

        Text txtBotaoA = null;
        Text txtBotaoB = null;
        string aux;

        txtBotaoA = a.GetComponentInChildren<Text>();
        txtBotaoB = b.GetComponentInChildren<Text>();

        aux = txtBotaoA.text;
        txtBotaoA.text = txtBotaoB.text;
        txtBotaoB.text = aux;
        
    }

}
