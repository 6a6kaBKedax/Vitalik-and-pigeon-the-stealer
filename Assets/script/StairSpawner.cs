using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairSpawner : MonoBehaviour
{
    private int[] objects;

    public float lastBlock;
    public float height;
    public float z;
    public float offset;


    public GameObject prefab;

    public Sprite[] sprites;
    public int[] counts;

    private void Start()
    {
        counts[1] = Mathf.RoundToInt(GlobalVariable.hardLevel * 0.8f);
        counts[2] = Mathf.RoundToInt(GlobalVariable.hardLevel * 0.1f);
        counts[3] = Mathf.RoundToInt(GlobalVariable.hardLevel * 0.1f);
        counts[0] = 100 - (counts[1] + counts[2] + counts[3]);

        objects = new int[counts[0] + counts[1] + counts[2] + counts[3]];
        int a = 0;
        int b = 0;
        foreach (int item in counts)
        {
            for (int i = 0; i < item; i++)
            {
                objects.SetValue(b, a);
                a += 1;
            }
            b += 1;
        }
        
    }

    void FixedUpdate()
    {
        if (transform.position.y + offset >= lastBlock)
        {
            int randomNumber = Random.Range(0, objects.Length - 1);
            int NowObject = objects[randomNumber];

            Vector3 newPos = new Vector3(0, lastBlock + height, z);
            GameObject newObj =  Instantiate(prefab, newPos, transform.rotation);
            newObj.GetComponent<SpriteRenderer>().sprite = sprites[NowObject];
            newObj.GetComponent<StairClass>().type = NowObject;
            newObj.GetComponent<StairClass>().sprite = sprites[0];

            if(NowObject == 0)
                newObj.GetComponent<Collider2D>().enabled = false;
            lastBlock = newPos.y;
        }
    }
}
