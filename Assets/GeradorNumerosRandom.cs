using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeradorNumerosRandom : MonoBehaviour
{
    // Start is called before the first frame update
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
        int qtd = int.Parse(numero.text);

        MyAwesomeCreator(qtd);

    }

    void MyAwesomeCreator(int qtd)
    {
        string valor;

        for(int i = 0; i < qtd; ++i)
        {
            GameObject goButton = (GameObject)Instantiate(prefabButton);
            Text valorBtn = goButton.GetComponentInChildren<Text>();
            valor = (Random.Range(0, 101).ToString());
            
            valorBtn.text = valor;
            goButton.transform.SetParent(ParentPanel, false);
        }
        
    }
}
