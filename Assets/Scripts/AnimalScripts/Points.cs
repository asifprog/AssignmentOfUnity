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
        //IAnimal
       // DestroyFruit
        TextDisplay.GetComponent<Text>().text =DestroyFruit.ScorePlayer.ToString();
    }
}
