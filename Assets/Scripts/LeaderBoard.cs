using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LeaderBoard : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject row;
    public Transform table;
    float xp = 0;
    float yp=0;
    float zp=0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LeaderB()
    {
        int len = SaveName.animalname.Count;
        for (int i = 0; i < len; i=i+2)
        {
            GameObject NewGO = Instantiate(row, table);
            Text[] texts = NewGO.GetComponentsInChildren<Text>();
            //texts[0].text = i.ToString();
            texts[0].text = SaveName.animalname[i];
            texts[1].text = SaveName.animalname[i+1];

        }
    }
}
