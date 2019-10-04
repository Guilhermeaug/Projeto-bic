using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScenes1 : MonoBehaviour
{
    
    public string level1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnMouseDown()
    {
        SceneManager.LoadScene(level1);
    }
}
