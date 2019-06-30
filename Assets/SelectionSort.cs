using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectionSort : Pai
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public RectTransform ParentPanel;
    private float tempo = 1;

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

                if (int.Parse(arr[j].GetComponentInChildren<Text>().text) < int.Parse(arr[min_idx].GetComponentInChildren<Text>().text))
                {
                    min_idx = j;
                }

                StartCoroutine(colorirAgain(tempo, arr[j]));
                yield return new WaitForSecondsRealtime(tempo);

            }
            
            int temp =  int.Parse(arr[min_idx].GetComponentInChildren<Text>().text);

            StartCoroutine(colorir(tempo, arr[min_idx]));
            yield return new WaitForSecondsRealtime(tempo);

            StartCoroutine(troca(tempo, arr[min_idx], arr[i]));
            StartCoroutine(troca(tempo, arr[i], temp));
            yield return new WaitForSecondsRealtime(tempo);

            StartCoroutine(colorirAgain(tempo, arr[i], arr[min_idx]));
            yield return new WaitForSecondsRealtime(tempo);


             
        } 
    } 
}
