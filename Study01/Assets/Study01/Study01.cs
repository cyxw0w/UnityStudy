using System.Collections;
// using System.Collections;��� �̸��� ���ӽ����̽��� ����ϰڴ�.
// ���ӽ����̽���??
// ���� �ڵ��� ������� �����ϸ� �ȴ�.
using System.Collections.Generic;
using TreeEditor;
using Unity.VisualScripting;
using UnityEngine;
// using���� �߰��� ���� ����ϰ� �ִ� �� ������, ������� �ʰ� �ִ� ���� ȸ������ ǥ�õ�

public class Player 
{
    private int hp = 100;
    private int power = 50;

    public void Attack()
    {
        Debug.Log(this.power + " �������� ������.");
    }

    public void Damage(int damage)
    {
        this.hp -= damage;
        Debug.Log(damage + "�������� �Ծ���.");
    }
}



public class Study01 : MonoBehaviour
    // C#�� {}�� �ڵ��� ������ �����Ѵ�.
    // Study01 �̶�� �̸��� Ŭ������ �������.
    // : MonoBehaviour -> Study01�̶�� Ŭ������ MonoBehaviour�� ��ӹ޾Ҵ�.
    // MonoBehaviour : ����Ƽ ���� ������Ʈ���� ��Ʈ�� �� �� �ִ� ����� ����ִ� Ŭ����
    // ����Ƽ������ �ڵ��� ���ϸ�� ������� ��ӹ޴�
    // Ŭ������ �̸��� ��ġ�ؾ� ����� �۵��Ѵ�.
{
    // Start is called before the first frame update
    // void Start(), void Update() �� �� C#�� �Լ�(�޼���)�̴�.
    // Start() : ���� ����� �� ����Ǵ� �Լ�
    // Update() : �� �����Ӹ��� ����Ǵ� �Լ�
    string str = "";

    void Start() 
    {
        str = "Hello World";
        print(str);
        str = "..";
        // �⺻������ ����Ƽ�� ��� ������ �տ� �������� ������ ��� �Ѵ�.
        // �ѹ� ������ �������� �ٲ� �� ����.
        // ��� ������ ���� or �ʱ�ȭ �� �� ����ؾ� �Ѵ�.

        int age; // age ��� �̸��� int ���� ������ ������ ������ �� ��
        age = 30; // age �ȿ� 30�̶�� ���� �ְ�
        Debug.Log(age); // age�� ����Ѵ�.        

        /*
         * ���ǹ�(if, switch)
         * switch�� : Ư���� ������ ���� üũ�ؼ� ���� ����
         * ����� �����ϴ� ����
         * 
           switch(����){
                case ������:
                    ���๮;
                    break;
                case ������ :
                    ���๮;
                    break;
                default:
                    ���๮ ;
                    break;
            }        
         */
        string grade = "A";
        switch (grade)
        {
            case "A":  
                print("���б� 100����");
                break;
            case "B":
                print("���б� 50����");
                break;
            default:
                print("���б� ����");
                break;
        }


        string name = "������";
        Debug.Log(name);



        int[] array1 = new int[5] {1,2,5,6,8};

        foreach (int i in array1)
        {
            print(i);
        }

        for (int i = 0; i < array1.Length; i++)
        {
            print((int)array1[i]);
        }

        Player myPlayer = new Player();
        myPlayer.Attack();
        myPlayer.Damage(30);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    /* ����Ƽ�� �ֿ� �����ֱ� �Լ� (Monobehaviour ���� �ֱ�)
     Awake : ��� ������Ʈ�� �ʱ�ȭ�� �� �� �� ȣ��
    -> Start : ù �������� ������Ʈ �Ǳ� ���� Ÿ�ֿ̹� ȣ��
    Update : �� �����Ӹ��� ȣ��
    FixedUpdate : ȣ�� �ֱⰡ ������ �Լ�
    LateUpdate : �� �������� ���� ������ ȣ��
     */
}

// ���� ¥�� �ּ�

/*
 * ���� �� ¥�� �ּ�
 * ���� �� ¥�� 
 */

/*
 * C#�̶� ???
 * .NET Framework : MS���� ������ �÷��� ������ ���� ȯ��
 * C#, C++, Visual Basic ��Ÿ ���
 * 
 * ��� ������ �⺻���� ��� �Ծ��� ����Ǵ� �͵��� �ְ�
 * �������� ������ �����ȴ�.
 * 
 * C#�� ������ ǥ���� Ư¡
 * 1) ��ҹ��ڸ� ��Ȯ�� �����Ѵ�. you YOU 
 * 2) C#�� ����� ��Ҹ� �����Ѵ�.
 * 3) C#�� �ݵ�� ���๮�� ���� ;�� �ٿ���� �Ѵ�.
 */
