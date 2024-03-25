using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidControl : MonoBehaviour
{
    /*
     * Rigidbody�� �ֿ� �Ӽ�
     * 
     * 1. velocity : �̵� �ӵ�
     * 2. angular velocity : ȸ�� �ӵ�
     * 
     * �������� ���� �༭ �̵��� �ϰų� ȸ���� ��.
     * 
     * ���� �޾ƾ����� �����̰� �ȴ�.
     * 
     * 
     * Rigidbody�� �ֿ� �޼���
     * 
     * 1. MovePosition : Ư�� ��ǥ�� �̵���Ŵ
     * 2. MoveRotation : Ư�� ������ ȸ����Ŵ
     * 3. *** Addforce : Ư�� �������� ���� ����
     * 4. AddTorque : Ư�� �������� ȸ������ ����
     */

    Rigidbody body;

    // Start is called before the first frame update
    void Start()
    {
        body = gameObject.GetComponent<Rigidbody>();
        // gameObject = ��ũ��Ʈ�� �����ִ� �ڱ� �ڽ� ������Ʈ�� ����Ŵ.
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //body.velocity = Vector3.left * 2.0f;

            //body.angularVelocity = Vector3.left * 2.0f;

            body.AddForce(Vector3.left);
            
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            //body.velocity = new Vector3(0,0,0);
            //body.angularVelocity = new Vector3(0,0,0);

            body.AddForce(new Vector3(0, 0, 0));
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
           // body.velocity = Vector3.right * 2.0f;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
           // body.velocity = new Vector3(0, 0, 0);
        }
    }
}
