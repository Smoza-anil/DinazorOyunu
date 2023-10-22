using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KaktusMoveScript : MonoBehaviour
{
     public float moveSpeed= 4f ;
    void Start()
    {
        
    }

   
    void Update()
    {
        transform.position =transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
    }
}
