using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    public string scenePortar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "player")
        {
            PlayerController playerController = other.GetComponent<PlayerController>();
            if(playerController != null)
            {
                SceneManager.LoadScene(scenePortar);
            }
        }
    }
}
