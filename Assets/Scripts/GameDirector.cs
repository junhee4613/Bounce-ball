using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    public GameObject redGround;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R) == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (!redGround.activeSelf)
        {
            StartCoroutine(RG2());
        }
        if (redGround.activeSelf)
        {
            StartCoroutine(RG());
        }
    }
    IEnumerator RG()
    {
        yield return new WaitForSeconds(3.0f);
        redGround.SetActive(false);
    }
    IEnumerator RG2()
    {
        yield return new WaitForSeconds(3.0f);
        redGround.SetActive(true);
    }
}
