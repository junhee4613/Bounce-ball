using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : MonoBehaviour
{
    
   
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "player")
        {
            PlayerController playerController = other.GetComponent<PlayerController>();

            if (playerController != null)
            {
                playerController.Die();

            }
            

        }
        if (other.tag == "Ground")
        {
            Destroy(gameObject);
        }

    }
    



}
