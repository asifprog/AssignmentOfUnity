using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Points : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject TextDisplay;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        TextDisplay.GetComponent<Text>().text = PlayerPrefs.GetString(DestroyFruit.ScorePlayer.ToString());
    }
}
