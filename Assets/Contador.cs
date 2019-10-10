using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Contador : Pai
{
    public RectTransform ParentPanel;
    private StaticValue info;
    int comparacoesSelection = 0, comparacoesInsertion = 0, comparacoesShell = 0, comparacoesBubble = 0, comparacoesQuick = 0;
    int trocasSelection = 0, trocasInsertion = 0, trocasShell = 0, trocasBubble = 0, trocasQuick = 0;

    public void preencheBotoes()
    {
        info = GameObject.FindObjectOfType<StaticValue>();

        Button []arr = pegaArray(ParentPanel);
        int[] selection = new int[arr.Length];
        int[] insertion = new int[arr.Length];
        int[] shell = new int[arr.Length];
        int[] bubble = new int[arr.Length];
        int[] quick = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            selection[i] = int.Parse(arr[i].GetComponentInChildren<Text>().text);
            insertion[i] = int.Parse(arr[i].GetComponentInChildren<Text>().text);
            shell[i] = int.Parse(arr[i].GetComponentInChildren<Text>().text);
            bubble[i] = int.Parse(arr[i].GetComponentInChildren<Text>().text);
            quick[i] = int.Parse(arr[i].GetComponentInChildren<Text>().text);
        }

        bubbleSort(bubble);
        selectionSort(selection);
        insertionSort(insertion);
        shellSort(shell);
        quickSort(quick, 0, quick.Length - 1);

        info.lerOperacoes(comparacoesSelection, comparacoesInsertion, comparacoesShell, comparacoesBubble, comparacoesQuick,
            trocasSelection, trocasInsertion, trocasShell, trocasBubble, trocasQuick);
            
        
    }

    void selectionSort(int[] arr)
    {
        int n = arr.Length;

         
        for (int i = 0; i < n - 1; i++)
        {
             
            int min_idx = i;
            for (int j = i + 1; j < n; j++)
            {
                comparacoesSelection++;

                if (arr[j] < arr[min_idx])
                    min_idx = j;
            }

            trocasSelection++;

            int temp = arr[min_idx];
            arr[min_idx] = arr[i];
            arr[i] = temp;
        }
    }


    void bubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
            {
                comparacoesBubble++;
                if (arr[j] > arr[j + 1])
                {
                    trocasBubble++;
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
                
    }

    void insertionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; ++i)
        {
            int key = arr[i];
            int j = i - 1;

            comparacoesInsertion++;               
            while (j >= 0 && arr[j] > key)
            {
                comparacoesInsertion++;
                trocasInsertion++;

                arr[j + 1] = arr[j];
                j = j - 1;
            }

            trocasInsertion++;
            arr[j + 1] = key;
        }
    }

    void shellSort(int[] arr)
    {
        int n = arr.Length;

        
        for (int gap = n / 2; gap > 0; gap /= 2)
        {
            
            for (int i = gap; i < n; i += 1)
            {
                
                int temp = arr[i];

                int j;

                comparacoesShell++;
                for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                {
                    arr[j] = arr[j - gap];
                    comparacoesShell++;
                    trocasShell++;
                }

                trocasShell++;
                arr[j] = temp;

            }
        }
    }

    int partition(int[] arr, int low,
                                   int high)
    {
        int pivot = arr[high];

        
        int i = (low - 1);
        for (int j = low; j < high; j++)
        {
            comparacoesQuick++;
            if (arr[j] < pivot)
            {
                comparacoesQuick++;
                trocasQuick++;

                i++;

                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        trocasQuick++; 
        int temp1 = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp1;

        return i + 1;
    }

    void quickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = partition(arr, low, high);

            quickSort(arr, low, pi - 1);
            quickSort(arr, pi + 1, high);
        }
    }

}
