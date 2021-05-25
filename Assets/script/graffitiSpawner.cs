using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class graffitiSpawner : MonoBehaviour
{
    public float lastBlock;
    public float height;
    public float z;
    public float offset;
    public GameObject[] objects;

    public float[] randomSpreadY;
    public float[] randomSpreadX;
    void FixedUpdate()
    {
        int value = Random.Range(0, objects.Length-1);
        if (transform.position.y + offset >= lastBlock )
        {
            Vector3 newPos = new Vector3(Random.Range(randomSpreadX[0], randomSpreadX[1]), lastBlock + height, z);
            Instantiate(objects[value], newPos, transform.rotation);
            lastBlock = newPos.y + Random.Range(randomSpreadY[0], randomSpreadY[1]);
        }
    }
}
