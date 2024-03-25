using System.Collections;
// using System.Collections;라는 이름의 네임스페이스를 사용하겠다.
// 네임스페이스란??
// 쉽게 코드의 폴더라고 이해하면 된다.
using System.Collections.Generic;
using TreeEditor;
using Unity.VisualScripting;
using UnityEngine;
// using으로 추가해 놓고 사용하고 있는 건 검은색, 사용하지 않고 있는 것은 회색으로 표시됨

public class Player 
{
    private int hp = 100;
    private int power = 50;

    public void Attack()
    {
        Debug.Log(this.power + " 데미지를 입혔다.");
    }

    public void Damage(int damage)
    {
        this.hp -= damage;
        Debug.Log(damage + "데미지를 입었다.");
    }
}



public class Study01 : MonoBehaviour
    // C#은 {}로 코드의 구역을 구분한다.
    // Study01 이라는 이름의 클래스를 만들었다.
    // : MonoBehaviour -> Study01이라는 클래스는 MonoBehaviour를 상속받았다.
    // MonoBehaviour : 유니티 엔진 오브젝트들을 컨트롤 할 수 있는 기능이 들어있는 클래스
    // 유니티에서는 코드의 파일명과 모노비헤비어를 상속받는
    // 클래스의 이름이 일치해야 제대로 작동한다.
{
    // Start is called before the first frame update
    // void Start(), void Update() 둘 다 C#의 함수(메서드)이다.
    // Start() : 앱이 실행될 때 실행되는 함수
    // Update() : 매 프레임마다 실행되는 함수
    string str = "";

    void Start() 
    {
        str = "Hello World";
        print(str);
        str = "..";
        // 기본적으로 유니티는 모든 변수의 앞에 변수형을 지정해 줘야 한다.
        // 한번 지정된 변수형은 바뀔 수 없다.
        // 모든 변수를 선언 or 초기화 한 후 사용해야 한다.

        int age; // age 라는 이름의 int 정수 형태의 변수를 선언을 한 후
        age = 30; // age 안에 30이라는 값을 넣고
        Debug.Log(age); // age를 출력한다.        

        /*
         * 조건문(if, switch)
         * switch문 : 특정한 변수의 값을 체크해서 값에 따라
         * 결과를 실행하는 구문
         * 
           switch(변수){
                case 변수값:
                    실행문;
                    break;
                case 변수값 :
                    실행문;
                    break;
                default:
                    실행문 ;
                    break;
            }        
         */
        string grade = "A";
        switch (grade)
        {
            case "A":  
                print("장학금 100만원");
                break;
            case "B":
                print("장학금 50만원");
                break;
            default:
                print("장학금 없음");
                break;
        }


        string name = "양현석";
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
    
    /* 유니티의 주요 생명주기 함수 (Monobehaviour 생명 주기)
     Awake : 모든 오브젝트가 초기화된 후 한 번 호출
    -> Start : 첫 프레임이 업데이트 되기 전의 타이밍에 호출
    Update : 매 프레임마다 호출
    FixedUpdate : 호출 주기가 일정한 함수
    LateUpdate : 매 프레임이 끝날 때마다 호출
     */
}

// 한줄 짜리 주석

/*
 * 여러 줄 짜리 주석
 * 여러 줄 짜리 
 */

/*
 * C#이란 ???
 * .NET Framework : MS에서 개발한 플랫폼 독립적 개발 환경
 * C#, C++, Visual Basic 기타 등등
 * 
 * 닷넷 언어끼리는 기본적인 언어 규약이 공통되는 것들이 있고
 * 데이터의 형식이 공유된다.
 * 
 * C#이 가지는 표현적 특징
 * 1) 대소문자를 정확히 구분한다. you YOU 
 * 2) C#은 띄어쓰기로 요소를 구분한다.
 * 3) C#은 반드시 실행문의 끝에 ;을 붙여줘야 한다.
 */
