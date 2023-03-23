using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        //tag = player destroy player
        if (other.tag == "Player")
        {
            Destroy(other.gameObject);
            Debug.Log("Player is dead");
        }
    }
}
