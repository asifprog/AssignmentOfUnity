using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
    
{
    public static CameraMovement instance;
    // Start is called before the first frame update
    //public GameObject[] prefabs;
    private Vector3 offset;
    [SerializeField]private GameObject player;
    private bool isInitialized = false;
    // int i = IAnimal.Cnt;
    //int i ;
    // Start is called before the first frame update
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }
    public void Initialize(GameObject player)
    {
        this.player = player;
        offset = transform.position - player.transform.position;

        isInitialized = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(isInitialized)
        transform.position = player.transform.position + offset;

    }
}
