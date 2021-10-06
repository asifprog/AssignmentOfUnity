using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Advertisements;

public class Ads : MonoBehaviour, IUnityAdsListener
{
#if UNITY_ANDROID
    string GameId = "4383857";
#else
 string GameId="4383857";
#endif
    // Start is called before the first frame update
    public static bool inc;
    void Start()
    {
        Advertisement.AddListener(this);
    }
    public void PlayRewardedAds()
    {
        if (Advertisement.IsReady("Rewarded_Android"))
        {
            Advertisement.Show("Rewarded_Android");
            inc = true;
        }
        else
        {
            Debug.Log("reward is not ready");
        }
    }
    public void OnUnityAdsReady(string placementId)
    {
        Debug.Log("RewardIsReady");
    }

    public void OnUnityAdsDidError(string message)
    {
        Debug.Log("Error");
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        Debug.Log("RewardIsStart");
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if (placementId == "Rewarded_Android" && showResult == ShowResult.Finished)
        {
            Debug.Log("Rewarded");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
