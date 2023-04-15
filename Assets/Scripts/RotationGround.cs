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
 //Ư�� ������ �߽����� ������Ʈ�� ȸ��  (�������� ��ġ, ȸ���ϴ� ����, ���ư��� �ӵ� * �����Ӵ� �ð�)
        gameObject.transform.RotateAround(pivot.position, Vector3.forward, rotatez * Time.deltaTime);
        gameObject.transform.Rotate(0, 0, GRz * Time.deltaTime);
       
    }
}
