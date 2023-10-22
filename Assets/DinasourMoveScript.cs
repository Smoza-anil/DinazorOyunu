using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinasourMoveScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float upAmount= 8;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidBody.velocity = Vector2.up * upAmount;
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            myRigidBody.Sleep();
        }
    }
}
