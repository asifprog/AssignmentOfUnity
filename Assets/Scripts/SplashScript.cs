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
        yield return finished = true;
    }
    private void LateUpdate()
    {
        if(finished==true)
        {
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        }
    }
    // Update is called once per frame
}
