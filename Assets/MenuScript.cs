using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public string newGameScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewGame()
    {
        
        SceneManager.LoadScene(newGameScene);
    }

    public void Credits()
    {

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
