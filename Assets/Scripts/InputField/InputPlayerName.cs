using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InputPlayerName : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField theinput;
    public static string inputname;

    private void Awake()
    {

        theinput.onValueChanged.AddListener(delegate { SavePlayerName(); });
    }
    // bool cflag = false;
    void Start()
    {

    }
    void SavePlayerName()
    {
        inputname = theinput.text;
        Debug.Log("name: " + inputname);
    }
    /*public bool EnterPress()
    {
        return true;
    }*/
    // Update is called once per frame
    /// <summary>
    /// Saves player name.
    /// </summary>

}
