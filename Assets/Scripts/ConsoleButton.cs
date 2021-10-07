using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class ConsoleButton : MonoBehaviour
{
    // Start is called before the first frame update

    public void OnClickMenu()
    {
        DestroyFruit.ScorePlayer = 0;
        IAnimal.time = 200;
        IAnimal.TimeEnd = 0;
        IAnimal.IAds = true;
       
        Console.ACnt = 0;
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
    public void OnClickReplay()
    {
        DestroyFruit.ScorePlayer = 0;
        IAnimal.time = 200;
        IAnimal.TimeEnd = 0;
        IAnimal.IAds = true;
        
        Console.ACnt = 0;
        SceneManager.LoadScene("BrightDay", LoadSceneMode.Single);

    }
}
