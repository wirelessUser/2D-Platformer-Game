using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GettingCompground : MonoBehaviour
{
    public GameObject[] charObj;
    public Rigidbody2D[] CharBodies;
    public Animator[] playerAnim;
    public BoxCollider2D[] colliders;
    void Start()
    {
        charObj = GameObject.FindGameObjectsWithTag("Player");
        colliders = GameObject.FindGameObjectWithTag("Player").GetComponents<BoxCollider2D>();
        CharBodies = GameObject.FindGameObjectWithTag("Player").GetComponents<Rigidbody2D>();
        playerAnim = GameObject.FindGameObjectWithTag("Player").GetComponents<Animator>();
        //     charObj.
        //  CharBodies.GetComponents<Rigidbody2D>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        for (int i = 0; i < CharBodies.Length; i++)
        {
           // collision.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 5));
        }
    }

}
