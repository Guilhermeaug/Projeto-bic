using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeMonkey.Utils;

public class Window_Graph_Comparacoes : MonoBehaviour
{

    [SerializeField] private Sprite circleSprite;
    private RectTransform graphContainer;
    private RectTransform labelTemplateX;
    private RectTransform labelTemplateY;
    private StaticValue info;
    //private GameObject tooltipGameObject;

    private void Awake()
    {
        info = GameObject.FindObjectOfType<StaticValue>();
        graphContainer = transform.Find("graphContainer").GetComponent<RectTransform>();
        labelTemplateX = graphContainer.Find("labelTemplateX").GetComponent<RectTransform>();
        labelTemplateY = graphContainer.Find("labelTemplateY").GetComponent<RectTransform>();
        //tooltipGameObject = graphContainer.Find("tooltip").gameObject;

        List<int> valueList = new List<int>() { 5, 98, 56, 45, 30};
        int[] listaComparacoes = info.getComparacoes();
        valueList[0] = listaComparacoes[0];
        valueList[1] = listaComparacoes[1];
        valueList[2] = listaComparacoes[2];
        valueList[3] = listaComparacoes[3];
        valueList[4] = listaComparacoes[4];

        showGraph(valueList);
    }

    private GameObject CreateCircle(Vector2 anchoredPosition)
    {
        GameObject gameObject = new GameObject("circle", typeof(Image));
        gameObject.transform.SetParent(graphContainer, false);
        gameObject.GetComponent<Image>().sprite = circleSprite;
        RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = anchoredPosition;
        rectTransform.sizeDelta = new Vector2(11, 11);
        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(0, 0);

        return gameObject;
    }

    private void showGraph(List<int> valueList)
    {
        float graphHeight = graphContainer.sizeDelta.y;
        float yMaximum = valueList[0];
        float yMinimum = valueList[0];

        foreach(int value in valueList)
        {
            if(value > yMaximum)
            {
                yMaximum = value;
            }
            
            if(value < yMinimum)
            {
                yMinimum = value;
            }
        }

        yMaximum = yMaximum + ((yMaximum - yMinimum) * 0.2f);
        yMinimum = yMinimum - ((yMaximum - yMinimum) * 0.2f);


        float xSize = 125f;

        GameObject lastCircleGameObject = null;
        for(int i = 0; i < valueList.Count; i++)
        {
            float xPosition = xSize + i * xSize;
            float yPosition = ((valueList[i] - yMinimum) / (yMaximum - yMinimum)) * graphHeight;
            GameObject circleGameObject = CreateCircle(new Vector2(xPosition, yPosition));
            if(lastCircleGameObject != null)
            {
                CreateDotConnection(lastCircleGameObject.GetComponent<RectTransform>().anchoredPosition, circleGameObject.GetComponent<RectTransform>().anchoredPosition);
            }
            lastCircleGameObject = circleGameObject;

            RectTransform labelX = Instantiate(labelTemplateX);
            labelX.SetParent(graphContainer, false);
            labelX.gameObject.SetActive(true);
            labelX.anchoredPosition = new Vector2(xPosition, -7f);

            if (i == 0)
                labelX.GetComponent<Text>().text = "SelectionSort";
            else if(i == 1)
                labelX.GetComponent<Text>().text = "InsertionSort";
            else if(i == 2)
                labelX.GetComponent<Text>().text = "ShellSort";
            else if(i == 3)
                labelX.GetComponent<Text>().text = "BubbleSort";
            else if(i == 4)
                labelX.GetComponent<Text>().text = "QuickSort";

            //labelX.GetComponent<Text>().text = i.ToString();

        }

        int separatorCount = 10;
        for(int i = 0; i <= separatorCount; i++)
        {
            RectTransform labelY = Instantiate(labelTemplateY);
            labelY.SetParent(graphContainer, false);
            labelY.gameObject.SetActive(true);
            float normalizedValue = i * 1f / separatorCount;
            labelY.anchoredPosition = new Vector2(-7f, normalizedValue * graphHeight);
            labelY.GetComponent<Text>().text = Mathf.RoundToInt(yMinimum + (normalizedValue * (yMaximum - yMinimum))).ToString();
             
        }   
    }

    private void CreateDotConnection(Vector2 dotPositionA, Vector2 dotPositionB)
    {
        GameObject gameObject = new GameObject("dotConnection", typeof(Image));
        gameObject.transform.SetParent(graphContainer, false);
        gameObject.GetComponent<Image>().color = new Color(1, 1, 1, .5f);
        RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
        Vector2 dir = (dotPositionB - dotPositionA).normalized;
        float distance = Vector2.Distance(dotPositionA, dotPositionB);
        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(0, 0);
        rectTransform.sizeDelta = new Vector2(distance, 3f);
        rectTransform.anchoredPosition = dotPositionA + dir * distance * .5f;
        rectTransform.localEulerAngles = new Vector3(0, 0, UtilsClass.GetAngleFromVectorFloat(dir));
    }

    /*private void ShowTooltip(string tooltipText, Vector2 anchoredPosition)
    {
        tooltipGameObject.SetActive(true);

        Text tooltipUIText = tooltipGameObject.transform.Find("text").GetComponent<Text>();
        tooltipUIText.text = tooltipText;

        float textPaddingSize = 4f;
        Vector2 backgroundSize = new Vector2(
            tooltipUIText.preferredWidth + textPaddingSize * 2f,
            tooltipUIText.preferredHeight + textPaddingSize * 2f
        );

        tooltipGameObject.transform.Find("background").GetComponent<RectTransform>().sizeDelta = backgroundSize;
    }

    private void HideToolTip()
    {
        tooltipGameObject.SetActive(false);
    }*/
}
