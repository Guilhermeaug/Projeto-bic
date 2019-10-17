using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeradorNumerosRandom2 : MonoBehaviour
{
    // Start is called before the first frame update
    //public InputField numero;
    public GameObject prefabButton;
    public RectTransform ParentPanel1, ParentPanel2;
    private StaticValue2 info;

    // Start is called before the first frame update
    void Start()
    {
        info = GameObject.FindObjectOfType<StaticValue2>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void gerarNumeros()
    {
        info = GameObject.FindObjectOfType<StaticValue2>();
        //int qtd = int.Parse(numero.text);
        int qtd = info.getQtd();
        Debug.Log(qtd);

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
            goButton.transform.SetParent(ParentPanel1, false);

            GameObject goButton2 = (GameObject)Instantiate(prefabButton);
            Text valorBtn2 = goButton2.GetComponentInChildren<Text>();
            
            valorBtn2.text = valor;
            goButton2.transform.SetParent(ParentPanel2, false);

        }
        
    }
}
