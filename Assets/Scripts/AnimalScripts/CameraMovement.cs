using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
    
{
    public static CameraMovement instance;
    private Vector3 offset;
    [SerializeField]private GameObject player;
    private bool isInitialized = false;
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
