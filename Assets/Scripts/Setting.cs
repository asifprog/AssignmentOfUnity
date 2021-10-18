using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting : MonoBehaviour
{
    public GameObject setting;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SettingOn()
    {
        setting.SetActive(true);
    }
    public void SettingOff()
    {
        setting.SetActive(false);
    }
}
