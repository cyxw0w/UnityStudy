using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class TransformControl : MonoBehaviour
{
    /*
     * Transform
     * �ֿ� ��� ���� (�ʵ�)
     * 
     * position : ��ġ ( position.x , position.y, position.z )
     * rotation : ���� 
     * scale : ����
     */

    public GameObject player; // ���� ������Ʈ ��ü
    public Transform playerT; // ���� ������Ʈ�� Transform ������Ʈ�� �����ϴ� ����

    public Transform cubeT;

    // �ʱ�ȭ���� ���� ������ �������� ���
    // �����Ϳ��� ���� ������ �����Ͽ� ����� �����ϴ�.


    

    float rX, rY, rZ;

    // Start is called before the first frame update
    void Start()
    {
        // �ڵ�󿡼� ���� ������ �ϰ� ���� ��쿡��
        GameObject playerManage = GameObject.Find("Player");

        print(this.transform.position); //��ũ��Ʈ ��ġ�� �ִ� �༮�� ��Ī�Ҷ�
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

        if (Input.GetKey(KeyCode.A)) // ���� ȸ��
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

        //�ڽ� ������Ʈ�� �����ϴ� ��
        // 1) ��ȣ�� ���� playerT.GetChild(0) -> �÷��̾��� ù��° �ڽ�
        // playerT.GetChild(2) or Player.transform.GetChild(2)

        // 2) playerT.Find("MainCamera")

        if ((Input.GetKey(KeyCode.Space)))
        {
            playerT.LookAt(cubeT.position);
        }
    }
}
