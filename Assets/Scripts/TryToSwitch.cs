using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TryToSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    public Canvas LCanvas;
    public Canvas PCanvas;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Screen.orientation);
        if (Screen.orientation == ScreenOrientation.Portrait)
        {
            LCanvas.gameObject.SetActive(false);
            PCanvas.gameObject.SetActive(true);

            //PCanvas.enabled = !PCanvas.enabled;
            // PCanvas.enabled = true;
            //SceneManager.LoadScene("PMenu", LoadSceneMode.Single);
        }
        else if (Screen.orientation == ScreenOrientation.Landscape)
        {
            LCanvas.gameObject.SetActive(true);
            PCanvas.gameObject.SetActive(false);
            //SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        }
    }
}
