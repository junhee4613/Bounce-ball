using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationGround : MonoBehaviour
{
    public float rotatez = -45f;
    public float GRz = 45f;
    public Transform pivot;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { 
 //특정 기준을 중심으로 오브젝트를 회전  (기준점의 위치, 회전하는 방향, 돌아가는 속도 * 프레임당 시간)
        gameObject.transform.RotateAround(pivot.position, Vector3.forward, rotatez * Time.deltaTime);
        gameObject.transform.Rotate(0, 0, GRz * Time.deltaTime);
       
    }
}
