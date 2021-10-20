using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameOver;
    public GameObject console;
    public GameObject pause;
    public GameObject gameplay;


    public void OnClickEnd()
    {
        Time.timeScale = 0;
        gameOver.SetActive(true);
        console.SetActive(false);
        pause.SetActive(false);

        gameplay.SetActive(false);

        //SceneManager.LoadScene(SceneName.sceneOfGame.BrightDay.ToString(), LoadSceneMode.Single);

    }
}
