using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ground : MonoBehaviour
{
    public float rotatez = -45f;
    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0f, 0f, rotatez * Time.deltaTime);
    }
}
