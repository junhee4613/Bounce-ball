using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public float x = 6.5f;
    public float y = -2f;
    public float strate = 0f;
    public float jump = 0f;
    
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
        if (gameObject.tag == "strate" && other.tag == "player")
        {
            other.transform.position = new Vector3(x, y, 0);
            other.GetComponent<Rigidbody2D>().gravityScale = 0;
            other.GetComponent<Rigidbody2D>().velocity = new Vector3(strate, 0f, 0f);
            other.GetComponent<PlayerController>().isGoal = true;
        }
        if(gameObject.tag == "jumpBox" && other.tag == "player")
        {
            
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, jump);
        }
    }
    
}
