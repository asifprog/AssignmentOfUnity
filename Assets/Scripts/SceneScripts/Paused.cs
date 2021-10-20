using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Paused : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject paused;
    public GameObject gamePlay;
    public GameObject console;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ResumeToGamePlay()
    {
        paused.SetActive(false);
        gamePlay.SetActive(true);
        console.SetActive(false);
        Time.timeScale = 1;

        // SceneManager.LoadScene("BrightDay", LoadSceneMode.Single);
    }
    public void CrossToGamePlay()
    {
        paused.SetActive(false);
        gamePlay.SetActive(true);
        console.SetActive(false);

        Time.timeScale = 1;

        //SceneManager.LoadScene("BrightDay", LoadSceneMode.Single);
    }
    public void MenuToMenu()
    {
        SceneManager.LoadScene(SceneName.sceneOfGame.Menu.ToString(), LoadSceneMode.Single);
    }
}
