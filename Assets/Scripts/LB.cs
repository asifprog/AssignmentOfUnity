using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LB : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LeaderBoard()
    {

        SceneManager.LoadScene("LeaderBoard", LoadSceneMode.Single);
    }
    public void LeaderBoardExit()
    {

        SceneManager.LoadScene("Console", LoadSceneMode.Single);
    }
}
