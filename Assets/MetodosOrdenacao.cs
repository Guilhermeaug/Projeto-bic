using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MetodosOrdenacao : Pai
{
    public RectTransform ParentPanel;
    //public Button buttonTrocas, buttonComparacoes;
    private float tempo = 1f, tempoInicial = 3;
    //int comparacoes = 0, trocas = 0;

    public void selection()
    {
        StartCoroutine(SelectionSort(pegaArray(ParentPanel)));
    }

    IEnumerator SelectionSort(Button[] arr)
    {
        yield return new WaitForSecondsRealtime(tempoInicial);

        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int min_idx = i;
            StartCoroutine(colorir(tempo, arr[min_idx]));

            for (int j = i + 1; j < n; j++)
            {
                StartCoroutine(colorir(tempo, arr[j]));
                yield return new WaitForSecondsRealtime(tempo);

                //comparacoes = comparacoes + 1;

                if (int.Parse(arr[j].GetComponentInChildren<Text>().text) < int.Parse(arr[min_idx].GetComponentInChildren<Text>().text))
                {
                    min_idx = j;
                }

                StartCoroutine(colorirAgain(tempo, arr[j]));
                yield return new WaitForSecondsRealtime(tempo);

            }

            int temp = int.Parse(arr[min_idx].GetComponentInChildren<Text>().text);

            //trocas = trocas + 1;

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

    public void insertion()
    {
        StartCoroutine(InsertionSort(pegaArray(ParentPanel)));
    }

    IEnumerator InsertionSort(Button[] arr)
    {
        yield return new WaitForSecondsRealtime(tempoInicial);

        int n = arr.Length;
        for (int i = 1; i < n; ++i)
        {
            int key = int.Parse(arr[i].GetComponentInChildren<Text>().text);
            int j = i - 1;

            StartCoroutine(colorirVermelho(tempo, arr[i]));
            yield return new WaitForSecondsRealtime(tempo);

            StartCoroutine(colorir(tempo, arr[j]));
            yield return new WaitForSecondsRealtime(tempo);

            StartCoroutine(colorirAgain(tempo, arr[j]));
            yield return new WaitForSecondsRealtime(tempo);

            //comparacoes = comparacoes + 1;
            while (j >= 0 && int.Parse(arr[j].GetComponentInChildren<Text>().text) > key)
            {
                //comparacoes = comparacoes + 1;
                // arr[j + 1].GetComponentInChildren<Text>().text = arr[j].GetComponentInChildren<Text>().text;
                StartCoroutine(colorir(tempo, arr[j + 1], arr[j]));
                yield return new WaitForSecondsRealtime(tempo);
                //tempo += 1;
                //trocas = trocas + 1;
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
            //trocas = trocas + 1;
            StartCoroutine(troca(tempo, arr[j + 1], key));
            yield return new WaitForSecondsRealtime(tempo);
            //tempo += 1;
            StartCoroutine(colorirAgain(tempo, arr[j + 1], arr[i]));
            yield return new WaitForSecondsRealtime(tempo);

            StartCoroutine(colorirAgain(tempo, arr[i]));
            yield return new WaitForSecondsRealtime(tempo);


        }
    }

    public void shell()
    {
        StartCoroutine(ShellSort(pegaArray(ParentPanel)));
    }

    IEnumerator ShellSort(Button[] arr)
    {
        yield return new WaitForSecondsRealtime(tempoInicial);

        int n = arr.Length;

        for (int gap = n / 2; gap > 0; gap /= 2)
        {

            for (int i = gap; i < n; i += 1)
            {

                int temp = int.Parse(arr[i].GetComponentInChildren<Text>().text);
                int j;

                StartCoroutine(colorirVermelho(tempo, arr[i]));
                yield return new WaitForSecondsRealtime(tempo);

                StartCoroutine(colorir(tempo, arr[i - gap]));
                yield return new WaitForSecondsRealtime(tempo);

                StartCoroutine(colorirAgain(tempo, arr[i - gap]));
                yield return new WaitForSecondsRealtime(tempo);

                //comparacoes = comparacoes + 1;
                for (j = i; j >= gap && int.Parse(arr[j - gap].GetComponentInChildren<Text>().text) > temp; j -= gap)
                {
                    //arr[j] = arr[j - gap];

                    //comparacoes = comparacoes + 1;
                    StartCoroutine(colorir(tempo, arr[j], arr[j - gap]));
                    yield return new WaitForSecondsRealtime(tempo);
                    //tempo += 1;
                    //trocas = trocas + 1;
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
                //trocas = trocas + 1;
                StartCoroutine(troca(tempo, arr[j], temp));
                yield return new WaitForSecondsRealtime(tempo);
                //tempo += 1;
                StartCoroutine(colorirAgain(tempo, arr[j], arr[i]));
                yield return new WaitForSecondsRealtime(tempo);
            }
        }
    }

    void trocarCorTodos(Button[] botoes)
    {
        foreach (Button x in botoes)
        {
            x.GetComponent<Image>().color = Color.white;
        }
    }

    IEnumerator espera()
    {
        yield return new WaitForSecondsRealtime(tempoInicial);
    }

    public void bubble()
    {
        espera();

        Button[] botoes = pegaArray(ParentPanel);

        //Button aux = null;

        Button botaoA = null;
        Button botaoB = null;


        for (int i = 0; i < botoes.Length; i++)
        {


            foreach (Button x in botoes)
            {

                if (botaoA == null)
                {
                    botaoA = x;
                }
                else if (botaoA != null && botaoB == null)
                {

                    botaoB = x;


                    tempo = tempo + 2;
                    StartCoroutine(colorir(tempo, x.GetComponent<Image>(), botaoA.GetComponent<Image>()));

                    tempo = tempo + 2;
                    StartCoroutine(comparar(tempo, botaoA, botaoB));


                }
                else if (botaoA != null && botaoB != null)
                {
                    botaoA = botaoB;
                    botaoB = x;

                    tempo = tempo + 2;
                    StartCoroutine(colorir(tempo, x.GetComponent<Image>(), botaoA.GetComponent<Image>()));

                    tempo = tempo + 2;
                    StartCoroutine(comparar(tempo, botaoA, botaoB));
                }
            }

            //Debug.Log("TROCANDO COR DE TODOS");
            botaoA = null;
            botaoB = null;
            //trocarCorTodos(botoes);
        }
    }


    IEnumerator comparar(float tempo, Button a, Button b)
    {

        Text txtBotaoA = null;
        Text txtBotaoB = null;
        string aux;

        yield return new WaitForSecondsRealtime(tempo);
        txtBotaoA = a.GetComponentInChildren<Text>();
        txtBotaoB = b.GetComponentInChildren<Text>();

        //comparacoes = comparacoes + 1;

        if (int.Parse(txtBotaoB.text) < int.Parse(txtBotaoA.text))
        {
            //trocas = trocas + 1;
            aux = txtBotaoA.text;
            txtBotaoA.text = txtBotaoB.text;
            txtBotaoB.text = aux;
        }




        a.GetComponent<Image>().color = Color.green;

        b.GetComponent<Image>().color = Color.green;
    }


    IEnumerator colorir(float tempo, Image a, Image b)
    {

        yield return new WaitForSecondsRealtime(tempo);
        a.color = Color.cyan;
        b.color = Color.cyan;
    }

    IEnumerator compararDois(float tempo)
    {
        Debug.Log(Time.time);
        yield return new WaitForSecondsRealtime(tempo);
        Debug.Log(Time.time);
    }



    private int pi = 0;
    public void quick()
    {

        Button[] botoes = pegaArray(ParentPanel);
        int tam = botoes.Length;

        StartCoroutine(QuickSort(pegaArray(ParentPanel), 0, tam - 1));
    }

    public IEnumerator partition(Button[] arr, int low, int high)
    {

        int pivot = int.Parse(arr[high].GetComponentInChildren<Text>().text);

        // index of smaller element 
        int i = (low - 1);

        for (int j = low; j < high; j++)
        {
            
            StartCoroutine(colorirVermelho(tempo, arr[high]));
            yield return new WaitForSecondsRealtime(tempo);

            StartCoroutine(colorir(tempo, arr[j]));
            yield return new WaitForSecondsRealtime(tempo);

            StartCoroutine(colorirAgain(tempo, arr[j]));
            yield return new WaitForSecondsRealtime(tempo);

            //comparacoes = comparacoes + 1;
            if (int.Parse(arr[j].GetComponentInChildren<Text>().text) <= pivot)
            {
                i++;

                //Debug.Log(arr[i].GetComponentInChildren<Text>().text);
                //Debug.Log(arr[j].GetComponentInChildren<Text>().text);

                //comparacoes = comparacoes + 1;
                StartCoroutine(colorir(tempo, arr[j]));
                yield return new WaitForSecondsRealtime(tempo);

                //trocas = trocas + 1;
                StartCoroutine(colorir(tempo, arr[i]));
                yield return new WaitForSecondsRealtime(tempo);

                StartCoroutine(trocaPares(tempo, arr[i], arr[j]));
                yield return new WaitForSecondsRealtime(tempo);

                StartCoroutine(colorirAgain(tempo, arr[j], arr[i]));
                yield return new WaitForSecondsRealtime(tempo);

            }
        }

        StartCoroutine(colorir(tempo, arr[i + 1]));
        yield return new WaitForSecondsRealtime(tempo);
        //trocas = trocas + 1;
        StartCoroutine(trocaPares(tempo, arr[i + 1], arr[high]));
        yield return new WaitForSecondsRealtime(tempo);
        StartCoroutine(colorirAgain(tempo, arr[high], arr[i + 1]));
        yield return new WaitForSecondsRealtime(tempo);

        pi = i + 1;

        StartCoroutine(QuickSort(arr, low, pi - 1));
        StartCoroutine(QuickSort(arr, pi + 1, high));

    }

    public IEnumerator QuickSort(Button[] arr, int low, int high)
    {
        if(pi == 0)
        {
            yield return new WaitForSecondsRealtime(tempoInicial);
        }

        if (low < high)
        {

            StartCoroutine(partition(arr, low, high));
            yield return new WaitForSecondsRealtime(1);

        }

    }
}
