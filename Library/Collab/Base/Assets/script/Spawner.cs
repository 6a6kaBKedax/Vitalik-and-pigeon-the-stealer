using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objects;
    
    public float lastBlock;
    public float height;
    public float z;
    public float offset;
    //public Random rnd = new Random();
    int value = Random.Range(0, 3);
    // Update is called once per frame
    public GameObject[] objects1;
    void FixedUpdate()
    {
        //int value = Random.Range(0, 3);
        if (transform.position.y + offset >= lastBlock)
        {
            Vector3 newPos = new Vector3(0, lastBlock + height, z);
            Instantiate(objects1[value], newPos, transform.rotation);
            lastBlock = newPos.y;
        }
    }
}
