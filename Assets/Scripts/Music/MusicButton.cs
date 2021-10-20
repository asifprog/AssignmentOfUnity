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
        if (string.Compare(PlayerPrefs.GetString(PlayPref.musicPlay), "0") == 0)
        {
            musicOnOff.GetComponent<Text>().text = "Music ON";
        }
        else
        {
            musicOnOff.GetComponent<Text>().text = "Music OFF";
        }
    }

    public void MusicOnOff()
    {

        if (string.Compare(PlayerPrefs.GetString(PlayPref.checkmusicplay), "false") == 0)
        {  
            MusiScript.Instance.PauseMusic(true);
            PlayPref.checkmusicplay ="true";
            PlayerPrefs.SetString(PlayPref.checkmusicplay, "true");
            musicOnOff.GetComponent<Text>().text = "Music ON";
        }
        else
        {
            MusiScript.Instance.PauseMusic(false);
            PlayPref.checkmusicplay = "false";
            PlayerPrefs.SetString(PlayPref.checkmusicplay, "false");
            musicOnOff.GetComponent<Text>().text = "Music OFF";
        }
    }

}
