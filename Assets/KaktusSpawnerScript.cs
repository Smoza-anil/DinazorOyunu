using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KaktusSpawnerScript : MonoBehaviour
{
   
    public GameObject Cactus;
    public float spawnRate= 2 ;
    private float timer = 0;

    void Start()
    {
        spawnCactus();

    }      void Update()
    {
       if(timer <spawnRate)
       {
        timer=timer+Time.deltaTime;
       }
       else
       {
        spawnCactus();
        timer = 0;
       }
    }
    void spawnCactus()
    {
         Instantiate(Cactus, transform.position, transform.rotation);
    }

}
