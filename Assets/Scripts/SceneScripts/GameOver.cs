using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;

        StartCoroutine(SplashWindow());
    }

    IEnumerator SplashWindow()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneName.sceneOfGame.Menu.ToString(), LoadSceneMode.Single);
    }
}
