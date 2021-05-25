using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pigeonScript : MonoBehaviour
{
    public GameObject prefab;
    public float[] cord;
    public int periodFrom; 
    public int periodTo;

    private int nowCord = 0;

    private float runAt;
    private bool isFired = false;
    private void Start()
    {
        runAt = Random.Range(periodFrom, periodTo);
    }

    void Update()
    {
        if(transform.position.x <= 0.05 && transform.position.x >= -0.05)
        {
            if(!isFired)
            {
                Instantiate(prefab, transform.position, transform.rotation).GetComponent<Rigidbody2D>().AddTorque(Random.Range(10f, 1000f));
                isFired = true;
            }
        }
            
        if(Time.timeSinceLevelLoad >= runAt)
        {
            if(Mathf.Round((transform.position.x - cord[Mathf.Abs(nowCord - 1)]) * 100f)/100f != 0f)
            {
                if(cord[Mathf.Abs(nowCord - 1)] - transform.position.x >=0)
                {
                    transform.position = new Vector3(transform.position.x + 0.03f, transform.position.y, transform.position.z);
                }else
                {
                    transform.position = new Vector3(transform.position.x - 0.03f, transform.position.y, transform.position.z);
                }
            }else
            {
                isFired = false;
                nowCord = Mathf.Abs(nowCord - 1);
                GetComponent<SpriteRenderer>().flipX = !GetComponent<SpriteRenderer>().flipX;
                runAt = Random.Range(periodFrom, periodTo) + Time.timeSinceLevelLoad;
            }
        }
    }
}
