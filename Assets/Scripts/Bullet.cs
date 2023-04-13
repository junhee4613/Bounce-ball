using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour     //ÃÑ¾Ë ±¸Çö
{
    public float bulletSpeed = 6f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.rb.velocity = rb.velocity * bulletSpeed;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController playerController = other.GetComponent<PlayerController>();
        if(other.tag == "player")
        {
            playerController.Die();
        }
    }
}
