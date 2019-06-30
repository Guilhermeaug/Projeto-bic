using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShellSort : Pai
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

    public void shell()
    {
        StartCoroutine(sort(pegaArray(ParentPanel)));
    }
    
    IEnumerator sort(Button[] arr)
    {
        int n = arr.Length;

        for (int gap = n / 2; gap > 0; gap /= 2)
        { 
           
            for (int i = gap; i < n; i += 1)
            {
         
                int temp = int.Parse(arr[i].GetComponentInChildren<Text>().text);

                int j;

                for (j = i; j >= gap && int.Parse(arr[j - gap].GetComponentInChildren<Text>().text) > temp; j -= gap)
                {
                    //arr[j] = arr[j - gap];

                    StartCoroutine(colorir(tempo, arr[j], arr[j - gap]));
                    yield return new WaitForSecondsRealtime(tempo);
                    //tempo += 1;
                    StartCoroutine(troca(tempo, arr[j], arr[j - gap]));
                    yield return new WaitForSecondsRealtime(tempo);
                    //tempo += 1;
                    StartCoroutine(colorirAgain(tempo, arr[j], arr[j - gap]));

                    yield return new WaitForSecondsRealtime(tempo);
                    //j = j - 1;
                    //tempo += 2;

                }     
                
                 //arr[j] = temp;
                 //arr[j + 1].GetComponentInChildren<Text>().text = key.ToString();
                 StartCoroutine(colorir(tempo, arr[j], arr[i]));
                 yield return new WaitForSecondsRealtime(tempo);
                 //tempo += 1;
                 StartCoroutine(troca(tempo, arr[j], temp));
                 yield return new WaitForSecondsRealtime(tempo);
                 //tempo += 1;
                 StartCoroutine(colorirAgain(tempo, arr[j], arr[i]));
                 yield return new WaitForSecondsRealtime(tempo);
            }
        }
    }
    
   
}
