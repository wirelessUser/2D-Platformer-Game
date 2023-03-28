using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisonPlayer : MonoBehaviour
{
    public Animator[] playerAnim;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        playerAnim = GameObject.FindGameObjectWithTag("Player").GetComponents<Animator>();

        ///
       

        // print("Collison detected By Player....... Player..........");
        // this.transform.localScale = new Vector3(1, 1,1);

        //if (collision.gameObject.tag == "Ground")
        //{
        //    print(" Isndie ONly Tag ");
        //}
        //if (collision.gameObject.CompareTag("Ground"))
        //{
        //    print(" Isndie Compare Tag ");    // CompareTag will show eeror If tag is not defined .
        //}


    }


}
