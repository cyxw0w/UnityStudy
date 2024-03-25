using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidControl : MonoBehaviour
{
    /*
     * Rigidbody의 주요 속성
     * 
     * 1. velocity : 이동 속도
     * 2. angular velocity : 회전 속도
     * 
     * 물리적인 힘을 줘서 이동을 하거나 회전을 함.
     * 
     * 힘을 받아야지만 움직이게 된다.
     * 
     * 
     * Rigidbody의 주요 메서드
     * 
     * 1. MovePosition : 특정 좌표로 이동시킴
     * 2. MoveRotation : 특정 각도로 회전시킴
     * 3. *** Addforce : 특정 방향으로 힘을 가함
     * 4. AddTorque : 특정 방향으로 회전력을 가함
     */

    Rigidbody body;

    // Start is called before the first frame update
    void Start()
    {
        body = gameObject.GetComponent<Rigidbody>();
        // gameObject = 스크립트가 속해있는 자기 자신 오브젝트를 가리킴.
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
