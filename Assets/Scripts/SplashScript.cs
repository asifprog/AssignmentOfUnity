using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScript : MonoBehaviour
{
    private bool finished = false;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SplashWindow());
    }

    IEnumerator SplashWindow()
    {
        yield return  new WaitForSeconds(3);
        SceneManager.LoadScene(SceneName.sceneOfGame.Menu.ToString(), LoadSceneMode.Single);
    }


}
