using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JoyStick : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    private float MoveSpeed = 1f;
   
    public FixedJoystick joystick;
    private AnimalMovement anim;
    public static bool stop;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<AnimalMovement>();
        joystick = FindObjectOfType<FixedJoystick>();
        // joystick = getcomponant.FindWithTag(Jystick).GetComponent<FixedJoystick>();

        // animgetcompnet<Playernimation>()
    }
    void Start()
    {
        
    }

    // Update is called once per frame
   void Update()
    {
       rb.velocity = new Vector3(joystick.Horizontal * MoveSpeed, rb.velocity.y, joystick.Vertical * MoveSpeed);
        var direction = new Vector3(joystick.Horizontal, 0f, joystick.Vertical);
        transform.Translate(direction * MoveSpeed * Time.deltaTime, Space.World);
       // transform.rotation = Quaternion.LookRotation(rb.velocity);
        if (joystick.Horizontal != 0f || joystick.Vertical != 0f)
        {
            anim.Walk(true);
            stop = false;
            rb.isKinematic = true;
           // Debug.Log(joystick.Horizontal);
            transform.rotation = Quaternion.LookRotation(rb.velocity);
        }
        else
        {
            anim.Walk(false);
            stop = true;
            //rb.isKinematic = false;
        }
    }
}
