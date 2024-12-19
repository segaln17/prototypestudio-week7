using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour
{
    private Scene currentScene;
    // Start is called before the first frame update
    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadNext()
    {

        SceneManager.LoadScene(currentScene.buildIndex + 1);
    }

    private void OnTriggerEnter(Collider other)
    {
        LoadNext();
    }

    public void Quit()
    {
        Application.Quit();
    }
}
