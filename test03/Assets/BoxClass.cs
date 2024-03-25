using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum boxType
{
    paperBox,
    woodBox,
    cabinet,
    vault
}

public class BoxClass : MonoBehaviour
{
    int id;
    boxType boxType;
    bool isOpen;
    item[] item; // 드랍될 수 있는 아이템의 종류
    int size; //사이즈의 크기 == 아이템 드랍되는 개수
    int reqStamina; //필요 스테미나

    //행동
    //아이템 결정

    public item SetItem() // 매개 변수는 아이템의 배열, 반환값은 아이템
    {
        item myItem = new item();
        return myItem;
    }
}
