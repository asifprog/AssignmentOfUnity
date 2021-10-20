using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject musicOnOff;
    private void Awake()
    {
        musicOnOff.GetComponent<Text>().text = "Music ON";
    }

    public void MusicOnOff()
    {

        if(StaticVariableOfGame.musicPlay==false)
        {  
            MusiScript.Instance.PauseMusic(true);
            StaticVariableOfGame.musicPlay = true;
            musicOnOff.GetComponent<Text>().text = "Music ON";
        }
        else
        {
            MusiScript.Instance.PauseMusic(false);
            StaticVariableOfGame.musicPlay = false;
            musicOnOff.GetComponent<Text>().text = "Music OFF";
        }
    }

}
