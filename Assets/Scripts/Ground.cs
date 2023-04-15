using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Ground : MonoBehaviour
{
    public float rotatez = -45f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0f, 0f, rotatez * Time.deltaTime);
    }
}
