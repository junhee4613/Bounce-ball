using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translate : MonoBehaviour
{
    
    //public 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*private void OnTriggerEnter2D(Collider2D other)        //등속직선 박스 개발중
    {
        PlayerController playerController = other.GetComponent<PlayerController>();
        Rigidbody2D rb = other.GetComponent<Rigidbody2D>();

        if(other.gameObject.tag == "player")
        {
            rb.constraints. = false;
            other.transform.position = new Vector2(other.transform.position.x, -2f);
            other.transform.Translate(0.5f, 0f, 0f);
        }
    } */
}
    