using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisonDeetction : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collison detected By Enemy");
        print("Time.tim" + Time.time);
    }
}
