using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;

//열거형이란 : enum - 
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


    // 행동
    // 이동
    // 공격
    public void Attack(GameObject matchObject){ // 매개 변수는 플레이어나 다른 동물
        
    }
    // 아이템을 결정
    public item SetItem() // 매개변수는 아이템의 배열, 반환값은 아이템
    {
        item myItem = new item();
        return myItem;
    }


    public Vector3[] Pos; // 순찰 지점들   
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
