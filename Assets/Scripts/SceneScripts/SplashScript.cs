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
        Debug.Log(PlayerPrefs.GetString(PlayPref.musicPlay));
        if (string.Compare(PlayerPrefs.GetString(PlayPref.musicPlay), "0") == 0)
        { 
            MusiScript.Instance.PlayMusic(SceneName.MusicClips.clip1);
        }
        else
        {
            MusiScript.Instance.PlayMusic(SceneName.MusicClips.clip1);
            MusiScript.Instance.PauseMusic(true);
        }
        StartCoroutine(SplashWindow());
    }

    IEnumerator SplashWindow()
    {
        yield return  new WaitForSeconds(3);
        SceneManager.LoadScene(SceneName.sceneOfGame.Menu.ToString(), LoadSceneMode.Single);
    }


}
