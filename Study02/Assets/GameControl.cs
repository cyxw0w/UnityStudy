using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;

public class GameControl : MonoBehaviour
{
    
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            count++;
            if (count == 4)
            {
                count = 0;
            }            
        }

        switch (count)
        {
            case 0:
                break;
            case 1:
                GameObject.Find("Cube").transform.Rotate(1, .5f, 1);
                break;
            case 2:
                GameObject.Find("Cube").transform.Rotate(1, .5f, 1);
                GameObject.Find("Cube2").transform.Rotate(1, .5f, 1);
                break;
            case 3:
                GameObject.Find("Cube").transform.Rotate(1, .5f, 1);
                GameObject.Find("Cube2").transform.Rotate(1, .5f, 1);
                GameObject.Find("Cube3").transform.Rotate(1, .5f, 1);
                break;
        }

        //GameObject.Find("Cube").transform.Rotate(1, .5f, 1);
        //GameObject.Find("오브젝트 이름")

        //GameObject.Find("Sphere").transform.Translate(1, .5f, 1);
        
    }
}
