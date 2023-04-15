using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
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
