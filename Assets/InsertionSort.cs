using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class InsertionSort : Pai
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

    public void insertion()
    {
        
        
        StartCoroutine(sort(pegaArray(ParentPanel)));
    }

    IEnumerator sort(Button[] arr)
    {
       
        int n = arr.Length;
        for (int i = 1; i < n; ++i)
        {
            int key = int.Parse(arr[i].GetComponentInChildren<Text>().text);
            int j = i - 1;

            while (j >= 0 && int.Parse(arr[j].GetComponentInChildren<Text>().text) > key)
            {
                // arr[j + 1].GetComponentInChildren<Text>().text = arr[j].GetComponentInChildren<Text>().text;
                StartCoroutine(colorir(tempo, arr[j + 1], arr[j]));
                yield return new WaitForSecondsRealtime(tempo);
                //tempo += 1;
                StartCoroutine(troca(tempo, arr[j + 1], arr[j]));
                yield return new WaitForSecondsRealtime(tempo);
                //tempo += 1;
                StartCoroutine(colorirAgain(tempo, arr[j + 1], arr[j]));

                yield return new WaitForSecondsRealtime(tempo);
                j = j - 1;
                //tempo += 2;
            }
            // arr[j + 1].GetComponentInChildren<Text>().text = key.ToString();
            StartCoroutine(colorir(tempo, arr[j + 1], arr[i]));
            yield return new WaitForSecondsRealtime(tempo);
            //tempo += 1;
            StartCoroutine(troca(tempo, arr[j + 1], key));
            yield return new WaitForSecondsRealtime(tempo);
            //tempo += 1;
            StartCoroutine(colorirAgain(tempo, arr[j + 1], arr[i]));
            yield return new WaitForSecondsRealtime(tempo);
        }
    }

}
