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

    /////////// [�ൿ]

    //�̵�
    public void Move() 
    {
        
    }    
    
    //Ž��
    public item Search() // �Ű������� ���� , ��ȯ���� ������
    {
        item myItem = new item();
        return myItem;
    }

    // ���
    public item Hunt() // �Ű������� ���� , ��ȯ���� ������
    {
        item myItem = new item();
        return myItem;
    }

    //������ ȹ��
    public item GetItem() // �Ű������� �����̳� ����, ��ȯ���� ������
    {
        item myItem = new item();
        return myItem;
    }

    //������ ���
    public void UseItem(item myItem) //�Ű������� ������, ��ȯ���� ����
    {
        // ������ ȿ�� ����
        DeleteItem(myItem);
    }

    //������ �Ҹ�
    public void DeleteItem(item myItem)
    {
        //������ ����
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