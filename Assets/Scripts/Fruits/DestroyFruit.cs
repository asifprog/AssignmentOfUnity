using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyFruit : MonoBehaviour
{

    public static int ScorePlayer = 0;
    //private int ScoreEnemy = 0;

    public static string pname;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fruit")) // 2
        {
            //other.gameObject.SetActive(false);
            // Debug.Log("fruit");
            Destroy(other.gameObject); // 3
            ScorePlayer = ScorePlayer + 1;
           
        }
        else if (other.CompareTag("FruitD"))  // 2
        {
            //other.gameObject.SetActive(false);
            //Debug.Log("fruit");
            Destroy(other.gameObject); // 3
            ScorePlayer = ScorePlayer + 2;
           
        }
    }
    /* private void OnCollisionEnter(Collision collision)
      {
          if (collision.gameObject.tag == "Fruit") // 2
          {
              //other.gameObject.SetActive(false);
             // Debug.Log("fruit");
              Destroy(collision.gameObject); // 3
              ScorePlayer = ScorePlayer + 1;
          }
          else if (collision.gameObject.tag == "FruitD") // 2
          {
              //other.gameObject.SetActive(false);
              //Debug.Log("fruit");
              Destroy(collision.gameObject); // 3
              ScorePlayer = ScorePlayer + 2;
          }

      }*/
}
