using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedGround : MonoBehaviour
{
    public GameObject redGround;
    
    // Update is called once per frame
    void Update()
    {
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
