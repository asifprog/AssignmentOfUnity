using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class ScreenResolutionHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {


        setMultiResolutionScreens(); 
    }

    public void setMultiResolutionScreens ()
    {
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;

        Canvas[] canvases = Resources.FindObjectsOfTypeAll<Canvas>();
        float targetAspectRatio = screenWidth / screenHeight; 
        foreach(Canvas canvas in canvases)
        {
            CanvasScaler canvasScaler =  canvas.GetComponent<CanvasScaler>();
            //if (EditorUtility.IsPersistent(canvas.transform.root))
            //    continue;

            if (canvasScaler == null)
                continue;

            if (targetAspectRatio > 2)
                canvasScaler.matchWidthOrHeight = 1;
            else if (targetAspectRatio > 1.7f)
                canvasScaler.matchWidthOrHeight = 0.8f; 

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
