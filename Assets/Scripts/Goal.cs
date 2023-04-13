using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public float x = 6.5f;
    public float y = -2f;
    public float strate = 0f;
    
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
            other.gameObject.transform.position = new Vector3(x, y, 0);
            other.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
            other.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(strate, 0f, 0f);
            other.gameObject.GetComponent<PlayerController>().isGoal = true;
        }
    }
    
}
