using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    float playerSpeed;
    public float speed=10;
    public Animator[] playerAnim;
    public Vector3 temp;
    public Rigidbody2D myRb;
    private void Awake()
    {
        // playerAnim = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
       playerAnim = GameObject.FindGameObjectWithTag("Player").GetComponents<Animator>();
       
        


    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        //Debug.Log(playerSpeed);
    }


    public void PlayerMove()
    {

        playerSpeed = Input.GetAxis(HelperNames.HorizontalAxis);
      //  playerSpeed = Input.GetAxisRaw(HelperNames.HorizontalAxis);
       
        // playerAnim.SetFloat("Speed", Mathf.Abs(playerSpeed));
        // Flip Player Left Right.......
        this.transform.Translate(new Vector2(playerSpeed , 0));
       // myRb.AddForce(new Vector2(playerSpeed*speed, 0));
       print("playerSpeed" + playerSpeed );
        temp = this.transform.localScale;
        if (playerSpeed == 1)
        {
            temp.x = Mathf.Abs(temp.x);
        }
        else if (playerSpeed <= 0)
        {
            temp.x = -1f * Mathf.Abs(temp.x);
        }

        this.transform.localScale = temp;




















    }
}
