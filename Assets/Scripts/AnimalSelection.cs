using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimalSelection : MonoBehaviour
{
    // Start is called before the first frame update
    public void BearInstantiate()
    {
       // AnimalInterface.Bpressed = true;
        AnimalInterface.BPress= true;
        SceneManager.LoadScene(SceneName.sceneOfGame.BrightDay.ToString(), LoadSceneMode.Single);
    }
    public void DeerInstantiate()
    {
        //AnimalInterface.Dpressed = true;
        AnimalInterface.DPress= true;
        SceneManager.LoadScene(SceneName.sceneOfGame.BrightDay.ToString(), LoadSceneMode.Single);
    }
}
