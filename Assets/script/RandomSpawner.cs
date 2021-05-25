using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject objects;
    public float RandomFactor;

    public Vector3 objOffset;


    public float lastBlock;
    public float height;
    public float z;
    public float offset;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.y + offset >= lastBlock)
        {
            Vector3 newPos = new Vector3(0, lastBlock + height, z);
            Instantiate(objects, newPos+ objOffset, transform.rotation);
            lastBlock = newPos.y;
        }
    }
}
