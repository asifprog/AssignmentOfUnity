using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusiScript : MonoBehaviour
{
    private static MusiScript inst=null;
    public static MusiScript instance
    {
        get { return inst; }
    }
    private void Awake()
    {
        if (inst != null)
        {
            Destroy(gameObject);
        }
        else
        {
            inst= this;
        }
        DontDestroyOnLoad(this.gameObject);
    }  
    
}
