using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeradorNumeros : MonoBehaviour
{

    public InputField numero;
    public GameObject prefabButton;
    public RectTransform ParentPanel;




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
        GameObject goButton = (GameObject)Instantiate(prefabButton);
        Text valorBtn = goButton.GetComponentInChildren<Text>();
        valorBtn.text = valor;
        goButton.transform.SetParent(ParentPanel, false);
    }

}
