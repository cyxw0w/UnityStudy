using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class CarController : MonoBehaviour
{
    float speed = 0.0f;
    Vector2 startPos;

    public GameObject flag;
    public GameObject text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.startPos = Input.mousePosition;
                       
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition;

            float swipeLength = endPos.x - this.startPos.x;

            this.speed = swipeLength /30.0f;
        }
        
        if (gameObject.transform.localPosition.x + speed <= 556.5f && gameObject.transform.localPosition.x + speed  >= -551.5f)
        {
            
           // gameObject.transform.Translate(speed, 0, 0);
        }

        transform.Translate(this.speed, 0,0);
        this.speed *= 0.98f;

        float length = (flag.transform.position.x - this.transform.position.x) / 10.0f;
        text.GetComponent<TextMeshProUGUI>().text = "Distance  " + length.ToString("F2") + "M ";
    }
}
