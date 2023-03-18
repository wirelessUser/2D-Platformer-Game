using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float HorizontalInput;

    private Animator playerAnim;
    private Vector3 temp;
    private float verticleInput;
    private Collider2D playerCollider;
    private Vector2 OriginalCollideSize = new Vector2(0.4f, 2f), OriginalOffset = new Vector2(-0.004f, 0.96f);

   

    private Vector2 CrouchCollideSize = new Vector2(0.58f, 1.31f), CrouchOffset = new Vector2(-0.004f, 0.6f);//Vector2(-0.004f,0.6f)
    public float playerSpeed;

    private Rigidbody2D playerRb;

    public float jumpForce;
    private float jumpInput;
    private bool isGrounded=true;

    private ScoreUI scorevar;
    private int scoreRaise=5;
    private void Awake()
    {
        scorevar = GameObject.FindGameObjectWithTag("UiController").GetComponent<ScoreUI>();
         playerAnim = GetComponent<Animator>();
        playerCollider = GetComponent<BoxCollider2D>();// differnce in colider2D vs BoxColider 2D?
        playerRb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
        HorizontalInput = Input.GetAxis(HelperNames.HorizontalAxis);
      
        PlayerMoveAnimations();
     
        Crouch();
        PlayerJump(isGrounded);
        PlayerMove(HorizontalInput);

        Jump();
        Debug.Log("IsGroudne>>" + isGrounded);
    }

    public void KeyCollected()
    {
        scorevar.ScoreController(scoreRaise);
    }

    public void PlayerMove(float inputHorizontal)
    {
       
            float playerPos = this.transform.position.x;
            playerPos+= HorizontalInput * playerSpeed * Time.deltaTime;
            this.transform.position = new Vector3(playerPos,transform.position.y,transform.position.z);
            
        
    }
    public void PlayerMoveAnimations()
    {

        

        playerAnim.SetFloat("Speed", Mathf.Abs(HorizontalInput));
        // Flip Player Left Right.......

        temp = this.transform.localScale;
        if (HorizontalInput > 0)
        {
            temp.x = Mathf.Abs(temp.x);
        }
        else if (HorizontalInput < 0)
        {
            temp.x = -1f * Mathf.Abs(temp.x);
        }

        this.transform.localScale = temp;


    }


    public void PlayerJump(bool isGrounded)
    {
        if(isGrounded==true)
        {
            playerAnim.SetBool("Jump",false);
        }


        else if (isGrounded == false)
        {
                   
                     playerAnim.SetBool("Jump", true);
                }
    }
   
    public void Crouch()
    {
        Vector2 SizeColl = playerCollider.bounds.size;
       Vector2 Offset = playerCollider.offset;
       
        if (Input.GetKeyDown(KeyCode.LeftControl)) 
        {
            Debug.Log("Crouch Pressed key");
            SizeColl = CrouchCollideSize;
             Offset = CrouchOffset;

            playerAnim.SetTrigger("Crouchh");

            //  Debug.Log("After_Sie>>" + playerCollider.bounds.size + "After_Offset>>" + playerCollider.bounds.size);

            playerAnim.SetBool("Crouch",true);
        }
        else
        {
          
            SizeColl = OriginalCollideSize;
            Offset = OriginalOffset;
            //Debug.Log("Before_Sie>>" + SizeColl + "Before_Offset>>" + Offset);
           
            
        }


    }

    public void Jump()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (playerRb.velocity.y <= 0&& isGrounded)
            {
                playerRb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
                isGrounded = false;
           }
           
        }
 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        
        }
    }


    public void CrouchAnim()
    {
        

        if (Input.GetKeyDown(KeyCode.LeftControl))  
        {
            Debug.Log("Crouch Pressed key");

          
            
        }
        else
        {

          
        }


    }

}
