using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectionSort : Pai
{
    
    public RectTransform ParentPanel;
    //public Button buttonTrocas, buttonComparacoes;
    private float tempo = 1;
    int comparacoes = 0, trocas = 0;

    public void selection()
    {
        StartCoroutine(sort(pegaArray(ParentPanel)));
    }
    
    IEnumerator sort(Button[] arr)
    { 
        int n = arr.Length; 
  
        for (int i = 0; i < n - 1; i++) 
        {  
            int min_idx = i;
            StartCoroutine(colorir(tempo, arr[min_idx]));

            for (int j = i + 1; j < n; j++)
            {
                StartCoroutine(colorir(tempo, arr[j]));
                yield return new WaitForSecondsRealtime(tempo);

                comparacoes = comparacoes + 1;

                if (int.Parse(arr[j].GetComponentInChildren<Text>().text) < int.Parse(arr[min_idx].GetComponentInChildren<Text>().text))
                {
                    min_idx = j;
                }

                StartCoroutine(colorirAgain(tempo, arr[j]));
                yield return new WaitForSecondsRealtime(tempo);

            }
            
            int temp =  int.Parse(arr[min_idx].GetComponentInChildren<Text>().text);

            trocas = trocas + 1;

            StartCoroutine(colorir(tempo, arr[min_idx]));
            yield return new WaitForSecondsRealtime(tempo);

            StartCoroutine(troca(tempo, arr[min_idx], arr[i]));
            StartCoroutine(troca(tempo, arr[i], temp));
            yield return new WaitForSecondsRealtime(tempo);

            StartCoroutine(colorirAgain(tempo, arr[i], arr[min_idx]));
            yield return new WaitForSecondsRealtime(tempo);
        }

        //string txtTrocas = trocas.ToString();
        //Text txtTrocas1 = buttonTrocas.GetComponentInChildren<Text>();
        //string valor1 = trocas.ToString();
        //txtTrocas1.text = valor1;

        //Text txtTrocas2 = buttonComparacoes.GetComponentInChildren<Text>();
        //string valor2 = comparacoes.ToString();
        //txtTrocas2.text = valor2;

    }

}
