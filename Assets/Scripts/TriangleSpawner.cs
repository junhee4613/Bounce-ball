using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleSpawner : MonoBehaviour
{
    public GameObject trianglePrefab;
    private float timeAfterSpawn;
    private float time = 3f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeAfterSpawn += Time.deltaTime;
        if(timeAfterSpawn > time)
        {
            timeAfterSpawn = 0f;
            GameObject triangle = Instantiate(trianglePrefab, transform.position, transform.rotation);
        }
        
    }
}
