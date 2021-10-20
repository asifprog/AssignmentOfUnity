using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectEpisodes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CrossToMenu()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
    public void SelectToGamePlay()
    {
        SceneManager.LoadScene("AnimalSelection", LoadSceneMode.Single);
    }
}
