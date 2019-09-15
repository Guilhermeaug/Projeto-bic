using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeradorNumeros2 : MonoBehaviour
{

    public InputField numero;
    public GameObject prefabButton;
    public RectTransform ParentPanel1, ParentPanel2;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void gerarNumeros()
    {
        string valor = numero.text;

        MyAwesomeCreator(valor);

    }

    void MyAwesomeCreator(string valor)
    {
        GameObject goButton1 = (GameObject)Instantiate(prefabButton);
        GameObject goButton2 = (GameObject)Instantiate(prefabButton);

        Text valorBtn1 = goButton1.GetComponentInChildren<Text>();
        valorBtn1.text = valor;
        Text valorBtn2 = goButton2.GetComponentInChildren<Text>();
        valorBtn2.text = valor;

        goButton1.transform.SetParent(ParentPanel1, false);
        goButton2.transform.SetParent(ParentPanel2, false);
    }

}
