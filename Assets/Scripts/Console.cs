﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class Console : MonoBehaviour
{
#if UNITY_ANDROID
    string GameId = "4383857";
#else
 string GameId="4383857";
#endif
    // Start is called before the first frame update
    public GameObject Screen;
    public GameObject CurrScore;
    public GameObject HighScore;
    public static int highscore=0;
    private string Win = "Congrats   You Win...";
    private string Loss = "Unfrtunately   You Loss...";
    void Start()
    {
        HighScore.GetComponent<Text>().text = "High Score:" + highscore.ToString();
      Advertisement.Initialize(GameId);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IAnimal.IAds == true)
        {
            if (Advertisement.IsReady("Interstitial_Android"))
            {
                Advertisement.Show("Interstitial_Android");
                IAnimal.IAds = false;
            }
        }
        else
        {
            if (IAnimal.WLFlag == true)
            {
                Screen.GetComponent<Text>().text = Win;
                CurrScore.GetComponent<Text>().text = "Current Score:" + DestroyFruit.ScorePlayer.ToString();
            }
            if (IAnimal.WLFlag == false)
            {
                Screen.GetComponent<Text>().text = Loss;
                CurrScore.GetComponent<Text>().text = "Current Score:" + DestroyFruit.ScorePlayer.ToString();
                if(Ads.inc==true)
                {
                    DestroyFruit.ScorePlayer = DestroyFruit.ScorePlayer + 5;
                    CurrScore.GetComponent<Text>().text = "Current Score:" + DestroyFruit.ScorePlayer.ToString();
                }
            }


            if (DestroyFruit.ScorePlayer >= highscore)
            {
                highscore = DestroyFruit.ScorePlayer;
                //text.text = "" + ;
                PlayerPrefs.SetInt("highscore", highscore);
                HighScore.GetComponent<Text>().text = "High Score:" + highscore.ToString();
                if (Ads.inc == true)
                {
                    DestroyFruit.ScorePlayer = DestroyFruit.ScorePlayer + 5;
                    CurrScore.GetComponent<Text>().text = "Current Score:" + DestroyFruit.ScorePlayer.ToString();
                }
            }
        }
       
    }
  
    void OnDestroy()
    {
        PlayerPrefs.SetInt("highscore", highscore);
        PlayerPrefs.Save();
    }

}