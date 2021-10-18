using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlay : MonoBehaviour
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
    public void PauseToPause()
    {
        Time.timeScale = 0;
        paused.SetActive(true);
        gamePlay.SetActive(false);
        console.SetActive(false);

        //SceneManager.LoadScene("Paused", LoadSceneMode.Single);
    }
}
