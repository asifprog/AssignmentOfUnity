using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SoundPlay : MonoBehaviour
{
    public GameObject musicPS;
    int mval = 1;
    bool flagMusic = true;
    public void OnMusic()
    {
        if (mval == 1)
        {
            flagMusic = false;
            music();
        }
        if (mval == 0)
        {
            flagMusic = true;
            music();
        }
       
    }
    public void music()
    {
        if (flagMusic == true)
        {

            musicPS.GetComponent<Text>().text = "Music ON";
            MusiScript.instance.GetComponent<AudioSource>().Play();
            mval = 0;
        }
        if (flagMusic == false)
        {
            MusiScript.instance.GetComponent<AudioSource>().Stop();
            musicPS.GetComponent<Text>().text = "Music OFF";
            mval = 0;
        }
    }
    public void Start()
    {
        musicPS.GetComponent<Text>().text = "Music ON";
        MusiScript.instance.GetComponent<AudioSource>().Play();

    }
}
