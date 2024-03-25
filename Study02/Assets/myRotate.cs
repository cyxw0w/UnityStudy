using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myRotate : MonoBehaviour
{

    public Transform Target;
    public Transform Sphere;
    public Transform Sphere2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Sphere.RotateAround(Target.position, Vector3.up, 90 * Time.deltaTime);
    }
}
