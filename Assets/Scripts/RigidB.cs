using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidB : MonoBehaviour
{
    float playerSpeed;
    public float moveSpeed;
    public Rigidbody2D myBody;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerSpeed = Input.GetAxisRaw(HelperNames.HorizontalAxis);
        if (playerSpeed>0/*Input.GetKey(KeyCode.LeftArrow)*/)
        {
          
            this.transform.Translate(new Vector2(playerSpeed, 0));
            //myBody.velocity = new Vector2(-1f, 0);
           // myBody.AddForce(new Vector2(-10f, 0));
           // print("Calling");
           //Vector2  temp = transform.position;
           // temp.x -= 0.2f;
           // transform.position = temp;

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(new Vector2(0.5f, 0));
            // myBody.velocity = new Vector2(1f, 0);
            // myBody.AddForce(new Vector2(10f, 0));
            //    Vector2 temp = transform.position;
            //    temp.x += 0.2f;
            //    transform.position = temp;

        }

        
}
}
