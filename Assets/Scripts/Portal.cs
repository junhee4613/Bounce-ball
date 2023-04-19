using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    public string scenePortar;
    
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
