using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class golubmenu : MonoBehaviour
{
    private bool dirRight = true;
    public float speed = 2.0f;
    private object direction;
    void FixedUpdate()
    {

        if (dirRight)
            transform.Translate(Vector2.right * speed * Time.deltaTime);

        else
            transform.Translate(-Vector2.right * speed * Time.deltaTime);

        if (transform.position.x >= 360)
        {

            dirRight = false;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }

        if (transform.position.x < -17)
        {
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
            dirRight = true;
        }

    }
}
