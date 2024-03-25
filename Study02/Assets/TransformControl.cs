using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class TransformControl : MonoBehaviour
{
    /*
     * Transform
     * 주요 멤버 변수 (필드)
     * 
     * position : 위치 ( position.x , position.y, position.z )
     * rotation : 각도 
     * scale : 배율
     */

    public GameObject player; // 게임 오브젝트 객체
    public Transform playerT; // 게임 오브젝트의 Transform 컴포넌트를 연결하는 변수

    public Transform cubeT;

    // 초기화되지 않은 변수를 설정했을 경우
    // 에디터에서 직접 변수를 지정하여 사용이 가능하다.


    

    float rX, rY, rZ;

    // Start is called before the first frame update
    void Start()
    {
        // 코드상에서 직접 지정을 하고 싶을 경우에는
        GameObject playerManage = GameObject.Find("Player");

        print(this.transform.position); //스크립트 위치에 있는 녀석을 지칭할때
        print(player.transform.position.x);
        print(player.transform.position.y);
        print(player.transform.position.z);

        rX = playerT.rotation.x;
        rY = playerT.rotation.y;
        rZ = playerT.rotation.z;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //playerT.position += new Vector3(.01f, 0, 0);
            playerT.position += playerT.right * .03f;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //playerT.position -= new Vector3(.01f, 0, 0);
            playerT.position -= playerT.right * .03f;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            playerT.position += playerT.forward * .03f;
            //playerT.position += new Vector3(0, 0, .01f);
        }
        if (Input.GetKey(KeyCode.DownArrow)) 
        {
            playerT.position -= playerT.forward * .03f;
            //playerT.position -= new Vector3(0, 0, .01f);
        }

        if (Input.GetKey(KeyCode.A)) // 왼쪽 회전
        {
            //playerT.rotation = Quaternion.Euler(rX, --rY, rZ);
            //playerT.rotation = new Quaternion(rX, rY, rZ); 

            //playerT.Find("Main Camera").rotation = Quaternion.Euler(rX, --rY, rZ);
            playerT.eulerAngles = new Vector3 (rX, --rY, rZ);
            //rY -= .01f;
            //playerT.Rotate(new Vector3(rX, rY, rZ)); 

        }
        
        if (Input.GetKey(KeyCode.D))
        {
            //playerT.rotation = Quaternion.Euler(rX, ++rY, rZ);
            //playerT.Find("Main Camera").rotation = Quaternion.Euler(rX, ++rY, rZ);
            playerT.eulerAngles = new Vector3(rX, ++rY, rZ);
        }

        if(Input.GetKey(KeyCode.W))
        {
            //playerT.rotation = Quaternion.Euler(rX, ++rY, rZ);
            playerT.Find("Main Camera").rotation = Quaternion.Euler(--rX, rY, rZ);
            playerT.eulerAngles = new Vector3(--rX, rY, rZ);
        }

        if (Input.GetKey(KeyCode.S))
        {
            //playerT.rotation = Quaternion.Euler(rX, ++rY, rZ);
            playerT.Find("Main Camera").rotation = Quaternion.Euler(++rX, rY, rZ);
            playerT.eulerAngles = new Vector3(++rX, rY, rZ);
        }

        //자식 오브젝트에 접근하는 법
        // 1) 번호로 접근 playerT.GetChild(0) -> 플레이어의 첫번째 자식
        // playerT.GetChild(2) or Player.transform.GetChild(2)

        // 2) playerT.Find("MainCamera")

        if ((Input.GetKey(KeyCode.Space)))
        {
            playerT.LookAt(cubeT.position);
        }
    }
}
