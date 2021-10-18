using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LB : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject leaderBoard;
    public GameObject menu;
    public GameObject animalSelect;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LeaderBoard()
    {

        leaderBoard.SetActive(true);
        menu.SetActive(false);
        animalSelect.SetActive(false);
       // SceneManager.LoadScene("LeaderBoard", LoadSceneMode.Single);
    }
    public void LeaderBoardExit()
    {

        leaderBoard.SetActive(false);
        menu.SetActive(true);
        animalSelect.SetActive(false);

        //SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
    public void AnimalSelect()
    {

        leaderBoard.SetActive(false);
        menu.SetActive(false);
        animalSelect.SetActive(true);

        //SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
}
