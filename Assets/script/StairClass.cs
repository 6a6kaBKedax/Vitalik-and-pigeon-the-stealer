using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairClass : MonoBehaviour
{
    
    public int type = 0;
    public Sprite sprite;


    private Vector2 tochdown;
    private Vector2 lastTouch;

    public GameObject hammer;

    private int a = 0;
    private void OnMouseDown()
    {
        tochdown = Input.mousePosition;
        a += 1;
        if(type == 1 && a >= 2)
        {
            GetComponent<SpriteRenderer>().sprite = sprite;
            GetComponent<Collider2D>().enabled = false;
            construct();
            type = 0;
        }
    }
    private void OnMouseDrag()
    {
        lastTouch = Input.mousePosition;
    }
    private void OnMouseUp()
    {

        if (type == 2)
        {
            Vector2 delta = (lastTouch - tochdown).normalized;
            if(delta.x >=0.8)
            {
                GetComponent<SpriteRenderer>().sprite = sprite;
                GetComponent<Collider2D>().enabled = false;
                construct();
                type = 0;
            }
        }
        if (type == 3)
        {
            Vector2 delta = (lastTouch - tochdown).normalized;
            if (delta.x <= -0.8)
            {
                GetComponent<SpriteRenderer>().sprite = sprite;
                GetComponent<Collider2D>().enabled = false;
                construct();
                type = 0;
            }
        }
    }
    private void construct()
    {
        Instantiate(hammer, transform);
    }
}
