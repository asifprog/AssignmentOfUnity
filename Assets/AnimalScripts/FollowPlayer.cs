using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FollowPlayer : MonoBehaviour
{

    // private
    // 
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FPlayer")) // 2
        {
            other.GetComponent<FAnimalMovement>().Initialize(gameObject);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // transform.position = Vector3.MoveTowards(transform.position, targ.transform.position, .03);
    }
}
