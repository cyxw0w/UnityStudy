using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;

//�������̶� : enum - 
public enum animalType
{
    rabbit,
    deer,
    wolf
}

public class AnimalClass : MonoBehaviour
{
    string animalName;
    int id;
    int HP;
    int att;
    int spd;
    item[] item;
    animalType animalType;


    // �ൿ
    // �̵�
    // ����
    public void Attack(GameObject matchObject){ // �Ű� ������ �÷��̾ �ٸ� ����
        
    }
    // �������� ����
    public item SetItem() // �Ű������� �������� �迭, ��ȯ���� ������
    {
        item myItem = new item();
        return myItem;
    }


    public Vector3[] Pos; // ���� ������   
    Vector3 targetPos;


    public void updateTargetPos(bool isPatrolStance, int posSize)
    {
        

        if (isPatrolStance) { 
            int rand = Random.Range(0, posSize - 1) % posSize;
            targetPos = Pos[rand]; 
        }
    }

    public void patrol()
    {
        transform.position = Vector3.MoveTowards(gameObject.transform.position, targetPos, 0.1f);
    }
    public void findPlayer(Vector3 playerPos)
    {
        targetPos = playerPos;
    }
}
