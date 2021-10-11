using System.Collections;
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
    public  static int ACnt=0;
    int cntanimal=0;
    public GameObject Screen;
    public GameObject CurrScore;
    public GameObject HighScore;
    public static int highscore;
    //public static int[] animalscore;
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
        if (IAnimal.IAds == true && ACnt==0)
        {
            if (Advertisement.IsReady("Interstitial_Android"))
            {
                Advertisement.Show("Interstitial_Android");
                ACnt = 1;
                IAnimal.IAds = false;
            }
            IAnimal.IAds = false;
            ACnt = 1;
        }
        else
        {
            if (IAnimal.WLFlag == true)
            {
                Screen.GetComponent<Text>().text = Win;
                CurrScore.GetComponent<Text>().text = "Current Score:" + DestroyFruit.ScorePlayer.ToString();
                StoreAnimalScore(IAnimal.pname,DestroyFruit.ScorePlayer);
            }
            if (IAnimal.WLFlag == false)
            {
                Screen.GetComponent<Text>().text = Loss;
                CurrScore.GetComponent<Text>().text = "Current Score:" + DestroyFruit.ScorePlayer.ToString();
                if(Ads.inc==true)
                {
                    IAnimal.time = IAnimal.time + 5;
                    DestroyFruit.ScorePlayer = DestroyFruit.ScorePlayer + 5;
                    CurrScore.GetComponent<Text>().text = "Current Score:" + DestroyFruit.ScorePlayer.ToString();
                    StoreAnimalScore(IAnimal.pname, DestroyFruit.ScorePlayer);

                    Ads.inc = false;
                }
            }


            if (DestroyFruit.ScorePlayer >= highscore)
            {
                highscore = DestroyFruit.ScorePlayer;
                //text.text = "" + ;
                PlayerPrefs.SetInt("highscore", highscore);
                PlayerPrefs.GetInt("highscore", highscore);
                OnDestroy();
                HighScore.GetComponent<Text>().text = "High Score:" + highscore.ToString();
                if (Ads.inc == true)
                {
                    IAnimal.time = IAnimal.time + 5;
                    DestroyFruit.ScorePlayer = DestroyFruit.ScorePlayer + 5;
                    CurrScore.GetComponent<Text>().text = "Current Score:" + DestroyFruit.ScorePlayer.ToString();
                    StoreAnimalScore(IAnimal.pname, DestroyFruit.ScorePlayer);
                    Ads.inc = false;
                }
            }
        }
       
    }
  
    void OnDestroy()
    {
        PlayerPrefs.SetInt("highscore", highscore);
        PlayerPrefs.Save();
    }
    void StoreAnimalScore(string animaln, int animals)
    {
        int len = IAnimal.animalname.Count;
        for (int k=0;k<len;k=k+2)
        {
            if (string.Compare(IAnimal.animalname[k], animaln)==0)
            {

                IAnimal.animalname[k+1] = animals.ToString();
               PlayerPrefs.SetString(IAnimal.animalname[k+1],animals.ToString());
                PlayerPrefs.Save();
                break;
            }
        }
    }
}
