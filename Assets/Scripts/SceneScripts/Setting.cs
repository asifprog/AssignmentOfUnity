using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting : MonoBehaviour
{
    public GameObject setting;
    public void SettingOn()
    {
        setting.SetActive(true);
    }
    public void SettingOff()
    {
        setting.SetActive(false);
    }
}
