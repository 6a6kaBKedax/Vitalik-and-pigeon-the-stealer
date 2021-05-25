using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dashScript : MonoBehaviour
{

    private Vector2 tochdown;
    private Vector2 lastTouch;
    private float speedBackup;
    private float _t;



    public float x;
    public Sprite side;
    public float scale;
    private void OnMouseDown()
    {
        tochdown = Input.mousePosition;
    }
    private void OnMouseDrag()
    {
        lastTouch = Input.mousePosition;
    }
    private void OnMouseUp()
    {

        Vector2 delta = (lastTouch - tochdown).normalized;
        if(delta.x >= 0.8)
        {
            _t = 1.5f;
        }
    }
    private void FixedUpdate()
    {
        if(_t > 0)
        {
            GetComponent<Animator>().StopPlayback();
            GetComponent<Animator>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
            GetComponent<SpriteRenderer>().sprite = side;
            GetComponent<SmothCamera>().needPosition = new Vector3(x, transform.position.y, transform.position.z);
            GetComponent<MainClass>()._disabled = true;
            _t -= Time.deltaTime;
        }else
        {
            
            GetComponent<Animator>().enabled = true;
            GetComponent<Collider2D>().enabled = true;
            GetComponent<MainClass>()._disabled = false;
        }
    }
}
