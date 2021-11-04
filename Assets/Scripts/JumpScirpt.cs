using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScirpt : MonoBehaviour
{
    public float playerSetX;
    public float playerSetY;
    public float playerSetZ;

    public float playerJumpHeight = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            transform.position += new Vector3(0, playerJumpHeight, 0);
        }

    }
}
