using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0;
    bool enabled = true;
    bool secCondition = false;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButtonDown(0)) {
            if (enabled)
            {
                this.rotSpeed = 20;
                enabled = false;
                secCondition = false;
                Debug.Log("마우스 클릭1");
            }
            else if(!enabled)
            {                                
                enabled = true;
                secCondition = true;
                Debug.Log("마우스 클릭2");
            }                        
        }

        if (secCondition) {
            math.clamp(rotSpeed *= 0.96f, 0, 10);
        }

        transform.Rotate(0, 0, this.rotSpeed);
    }

}
