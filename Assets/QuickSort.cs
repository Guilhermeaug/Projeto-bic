using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuickSort : Pai
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
    private int pi = 0;

    public void quick()
    {
        
        Button[] botoes = pegaArray(ParentPanel);
        int tam = botoes.Length;

        StartCoroutine(sort(pegaArray(ParentPanel), 0, tam - 1));
    }

    public IEnumerator partition(Button[] arr, int low, int high)
    {
        int pivot = int.Parse(arr[high].GetComponentInChildren<Text>().text);
        
        
        // index of smaller element 
        int i = (low - 1);

        
        for (int j = low; j < high; j++)
        {
            // If current element is smaller  
            // than or equal to pivot 
            StartCoroutine(colorir(tempo, arr[high]));
            yield return new WaitForSecondsRealtime(tempo);

            if (int.Parse(arr[j].GetComponentInChildren<Text>().text) <= pivot)
            {
                i++;


                //Debug.Log(arr[i].GetComponentInChildren<Text>().text);

                //Debug.Log(arr[j].GetComponentInChildren<Text>().text);

                StartCoroutine(colorir(tempo, arr[j]));
                yield return new WaitForSecondsRealtime(tempo);
                StartCoroutine(trocaPares(tempo, arr[i], arr[j]));
                yield return new WaitForSecondsRealtime(tempo);
                StartCoroutine(colorirAgain(tempo, arr[j]));
                yield return new WaitForSecondsRealtime(tempo);

            }

            
        }

        StartCoroutine(colorir(tempo, arr[i + 1]));
        yield return new WaitForSecondsRealtime(tempo);
        StartCoroutine(trocaPares(tempo, arr[i + 1], arr[high]));
        yield return new WaitForSecondsRealtime(tempo);
        StartCoroutine(colorirAgain(tempo, arr[high], arr[i + 1]));
        yield return new WaitForSecondsRealtime(tempo);



        pi = i + 1;

        StartCoroutine(sort(arr, low, pi - 1));

        StartCoroutine(sort(arr, pi + 1, high));

    }

    public IEnumerator sort(Button[] arr, int low, int high)
    {
        
        if (low < high)
        {
            
            StartCoroutine(partition(arr, low, high));
            yield return new WaitForSecondsRealtime(1);

           
        }
       
    }

}
