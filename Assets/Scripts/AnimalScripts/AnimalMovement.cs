using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMovement : MonoBehaviour
{
    // Start is called before the first frame update
    

    // Update is called once per frame
    //protected Joystick joystick;
    public Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    //public float MovementSpeed;
    //private bool flag;
    void Start()
    {
        //StartCoroutine(Jump());
        //StartCoroutine(Attack());
       // joystick = FindObjectOfType<Joystick>();

    }
    public void Walk (bool walk)
    {
        animator.SetBool("Walk", walk);
    }

    /*  private void Update()
      {
          var rigidbody = GetComponent<Rigidbody>();
          rigidbody.velocity = new Vector3(joystick.Horizontal * 10f + (Input.GetAxis("Horizontal") * 10f), 
              rigidbody.velocity.y, joystick.Vertical * 10f + Input.GetAxis("Vertical") * 10f);
      }*/

    // Update is called once per frame
     /*void Update()
     {
         float HInput = Input.GetAxis("Horizontal");
         float VInput = Input.GetAxis("Vertical");


         if (HInput > 0)
         {

             animator.SetBool("Walk", true);

            transform.Translate(Vector3.right * Time.deltaTime);
             //UpdateMovement();
         }
         else if (HInput < 0)
         {

             animator.SetBool("Walk", true);
             transform.Translate(Vector3.left * Time.deltaTime);
             //UpdateMovement();
         }
         else if (VInput > 0)
         {

             animator.SetBool("Walk", true);
           transform.Translate(Vector3.forward * Time.deltaTime);
             //UpdateMovement();
         }
         else if (VInput < 0)
         {

             animator.SetBool("Walk", true);
             transform.Translate(Vector3.back * Time.deltaTime);
             //UpdateMovement();
         }
         else
         {
             animator.SetBool("Walk", false);
         }
     }*/
}
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("IsJump", true);

        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetBool("IsAttack", true);
        }        else
        {
            animator.SetBool("IsAttack", false);
            animator.SetBool("IsJump", false);
            animator.SetFloat("IsMove", -1);
            // animator.SetFloat("Move", 0);
        }*/

    //}
    /*private void UpdateMovement()
    { 
       // float OriginalXAxis = transform.positon.x;
        float HInput = Input.GetAxis("Horizontal");
        if (HInput > 0)
        {
            transform.Translate(transform.right*MovementSpeed);
        }
        else if(HInput<0)
        {
            transform.Translate(transform.right * MovementSpeed);
        }
       if(OriginalXAxis != transform.positon.x)
            animator.SetBool("IsMoving", true);
        else
            animator.SetBool("IsMoving", false);

    }*/
    /* IEnumerator Jump()
     {
         TurnOffEerything();
         yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space) ==true);
         animator.SetBool("IsJump", true);
         StartCoroutine(Jump());
     }
     IEnumerator Attack()
     {
         TurnOffEerything();
         yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.F)==true);
         animator.SetBool("IsAttack", true);
         StartCoroutine(Attack());
     }

     void TurnOffEerything()
     {
         animator.SetBool("IsAttack", false);
         animator.SetBool("IsJump", false);
     }*/
//}
