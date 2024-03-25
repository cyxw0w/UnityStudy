using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RouletteControl : MonoBehaviour
{
    float rotSpeed;
    bool flag = false;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            if (!flag)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
        }

        if (flag)
        {
            gameObject.transform.Rotate(0, 0, 30);
        }
        else
        {
            gameObject.transform.Rotate(0, 0, 0);
        }
        
    }
}
