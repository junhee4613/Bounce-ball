using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCircle : MonoBehaviour          //원이 특정 크기로 작아지고 커지는 걸 반복하는 거 구현하기
{
    bool a = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(a)
        {
            gameObject.transform.localScale = Vector3.one * 4 * Time.deltaTime;
            a = false;
        }
        if (!a)
        {
            gameObject.transform.localScale = Vector3.one * Time.deltaTime;
            a = true;
        }
    }
}
