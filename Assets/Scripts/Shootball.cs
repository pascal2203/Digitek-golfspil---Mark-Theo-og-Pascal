using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootball : MonoBehaviour
{
    public float startPosx;
    public float startPosz;
    public float endPosx;
    public float endPosz;
    public float directionx;
    public float directionz;
    Rigidbody myRigidbody;
    public float shootPower = 10f;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPosz = Input.mousePosition.z;
            startPosx = Input.mousePosition.x;
        }
    }

    void OnMouseUp()
    {
        if (Input.GetMouseButtonUp(0))
        {
            endPosx = Input.mousePosition.x;
            endPosz = Input.mousePosition.z;
            directionx = startPosx - endPosx;
            directionz = startPosz - endPosz;
            myRigidbody.isKinematic = false;
            myRigidbody.AddForce(directionx * shootPower, 0, directionz * shootPower);
        }
    }
}