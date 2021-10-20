using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusiScript : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioClip[] musicClips;

    private static MusiScript inst=null;
    public static MusiScript Instance
    {
        get { return inst; }
    }
    void Awake()
    {
        if (inst != null)
        {
            Destroy(gameObject);
        }
        else
        {
            inst = this;
        }
        DontDestroyOnLoad(this.gameObject);

        //PlayMusic(Clips.buttonPress);
    }

    public void PlayMusic(SceneName.MusicClips clp)
    {
       
        musicSource.clip = musicClips[(int)clp];
        musicSource.Play();
        
        //musicClips[(int)c]
    }
    public void PauseMusic(bool pause)
    {
        if(pause)
        {
            musicSource.Pause();

            PlayerPrefs.SetString(PlayPref.musicPlay, "1");
        }
        else
        {

            PlayerPrefs.SetString(PlayPref.musicPlay, "0");
            musicSource.UnPause();
        }
    }



}
