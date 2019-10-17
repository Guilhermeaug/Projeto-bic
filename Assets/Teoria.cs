using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Teoria : MonoBehaviour
{
    Text txt;
    private StaticValue info;

    // Start is called before the first frame update
    void Start()
    {
        info = GameObject.FindObjectOfType<StaticValue>();
        txt = gameObject.GetComponent<Text>();
        //txt.text = "Teste";

        imprimeTexto(info.getMetodo());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void imprimeTexto(string metodo)
    {
        if (metodo == "btnSelection")
        {
            txt.text = "A ordenação por seleção (do inglês, selection sort) é um algoritmo de ordenação baseado " +
                "em se passar sempre o menor valor do vetor para a primeira posição (ou o maior dependendo da ordem requerida), " +
                "depois o de segundo menor valor para a segunda posição, e assim é feito sucessivamente " +
                "com os n-1 elementos restantes, até o penultimo elementos.";

        }
        else if (metodo == "btnInsertion")
        {
            txt.text = "Neste algoritmo a lista é percorrida da esquerda para a direita, " +
                "à medida que avança vai deixando os elementos mais à esquerda ordenados." +
                "O algoritmo funciona da mesma forma que as pessoas usam para ordenar cartas em um jogo de baralho como o pôquer.";

        }
        else if (metodo == "btnShell")
        {
            txt.text = "É um refinamento do método de inserção direta. " +
                "O algoritmo difere do método de inserção direta pelo fato de no lugar de considerar o array " +
                "a ser ordenado como um único segmento, ele considera vários segmentos " +
                "sendo aplicado o método de inserção direta em cada um deles. Basicamente o algoritmo passa várias vezes " +
                "pela lista dividindo o grupo maior em menores. Nos grupos menores é aplicado o método da ordenação por inserção.";

        }
        else if (metodo == "btnBubble")
        {
            txt.text = "Bubble sort é o algoritmo mais simples, mas o menos eficientes. " +
                 "Neste algoritmo cada elemento da posição i será comparado com o elemento da posição i + 1, " +
                 "ou seja, um elemento da posição 2 será comparado com o elemento da posição 3. " +
                 "Caso o elemento da posição 2 for maior que o da posição 3, eles trocam de lugar e assim sucessivamente.";

        }
        else if (metodo == "btnQuick")
        {
            txt.text = "O Quicksort é o algoritmo mais eficiente na ordenação por comparação. " +
                "Nele se escolhe um elemento chamado de pivô, a partir disto é organizada " +
                "a lista para que todos os números anteriores a ele sejam menores que ele, e todos os números posteriores a ele " +
                "sejam maiores que ele. Ao final desse processo o número pivô já está em sua posição final. " +
                "Os dois grupos desordenados recursivamente sofreram o mesmo processo até que a lista esteja ordenada.";
        }
    }


}
