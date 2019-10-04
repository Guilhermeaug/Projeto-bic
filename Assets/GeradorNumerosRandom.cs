using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeradorNumerosRandom : MonoBehaviour
{
    // Start is called before the first frame update
    //public InputField numero;
    public GameObject prefabButton;
    public RectTransform ParentPanel;
    private StaticValue info;

    // Start is called before the first frame update
    void Start()
    {
        info = GameObject.FindObjectOfType<StaticValue>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void gerarNumeros()
    {
        //int qtd = int.Parse(numero.text);
        int qtd = info.getQtd();

        MyAwesomeCreator(qtd);

    }

    void MyAwesomeCreator(int qtd)
    {
        string valor;
        int inicio, fim;

        inicio = info.getInicio();
        fim = info.getFim();

        for(int i = 0; i < qtd; ++i)
        {
            GameObject goButton = (GameObject)Instantiate(prefabButton);
            Text valorBtn = goButton.GetComponentInChildren<Text>();
            valor = (Random.Range(inicio, fim + 1).ToString());
            
            valorBtn.text = valor;
            goButton.transform.SetParent(ParentPanel, false);
        }
        
    }
}
