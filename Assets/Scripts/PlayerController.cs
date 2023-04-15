using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float jumpForce = 6f;
    Rigidbody2D rb;
    public bool isGoal = false;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
   
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Translate(0.05f, 0f, 0f);

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Translate(-0.05f, 0f, 0f);
        }
        if(isGoal && Input.GetKeyDown(KeyCode.RightArrow) || isGoal && Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.velocity = Vector2.zero;
            rb.gravityScale = 1f;
            isGoal = false;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, jumpForce);
        }
        
    }
    



    public void Die()
    {
        Destroy(gameObject);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Set()
    {


    }
}
