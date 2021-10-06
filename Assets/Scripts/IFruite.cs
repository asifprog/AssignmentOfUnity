using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using unit
public class IFruite : MonoBehaviour
{
    /* // Start is called before the first frame update
     public GameObject prefabs;
     public Transform[] FruitsPoints;
     private Transform ActualFruits;

     // Update is called once per frame
     void Update()
     {
         FruitsGo();
     }

     void FruitsGo()
     {
         ActualFruits = FruitsPoints[Random.Range(0, FruitsPoints.Length)];
         GameObject.Instantiate(prefabs, ActualFruits);
     }*/

    //public GameObject[] fruits;
    public GameObject[] prefabs;
    //public 
    //gameObject.layer
    int xpos;
    int zpos;
   // int objectToGenerate;
    int objectQuantity=0;

   IEnumerator ObjectGenerator()
    {
        for (int i = 0; i < prefabs.Length; i++)
        {
            while (objectQuantity < 2)
            {
               // Debug.Log("FruitG");
                // objectToGenerate = Random.Range(1, 11);
                xpos = Random.Range(25, 63);
                zpos = Random.Range(17, 48);
                Instantiate(prefabs[i], new Vector3(xpos, 10, zpos), Quaternion.identity);
                Debug.Log("FruitG1");
                // prefabs[i].layer=LayerMask.NameToLayer("Fruit");
                //LayerMask.LayerToName(8);
                yield return new WaitForSeconds(0.1f);
               // Debug.Log("FruitG2");
                // objectToGenerate += 1;
                objectQuantity += 1;
               // Debug.Log("FruitG3");
            }
            objectQuantity = 0;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ObjectGenerator());
    }
}
