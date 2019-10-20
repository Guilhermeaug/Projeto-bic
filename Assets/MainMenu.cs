using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGameGeral()
    {
        SceneManager.LoadScene("GeralRework");
    }

    public void PlayGameSimultaneo()
    {
        SceneManager.LoadScene("TesteSimultaneo");
    }
}
