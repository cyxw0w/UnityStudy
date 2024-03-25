using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClass : MonoBehaviour
{
    string playerName;
    int id;
    int hunger;
    int stamina;
    int HP;
    int att;

    item[] myItem;
    item weapon;
    float mxaWeight;
    float currentWeight;

    /////////// [행동]

    //이동
    public void Move() 
    {
        
    }    
    
    //탐색
    public item Search() // 매개변수는 상자 , 반환값은 아이템
    {
        item myItem = new item();
        return myItem;
    }

    // 사냥
    public item Hunt() // 매개변수는 동물 , 반환값은 아이템
    {
        item myItem = new item();
        return myItem;
    }

    //아이템 획득
    public item GetItem() // 매개변수는 동물이나 상자, 반환값은 아이템
    {
        item myItem = new item();
        return myItem;
    }

    //아이템 사용
    public void UseItem(item myItem) //매개변수는 아이템, 반환값은 없음
    {
        // 아이템 효과 적용
        DeleteItem(myItem);
    }

    //아이템 소멸
    public void DeleteItem(item myItem)
    {
        //아이템 삭제
    }
}

public class item
{
    string name;
    int id;

    int hungerBonus;
    int staminaBonus;
    int hpBonus;
    int attBonus;
    float weight;
}