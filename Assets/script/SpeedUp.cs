using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    public float speedUp = 30f;
    public float maxSpeed = 0.1f;

    private float _t;

    // Update is called once per frame
    void Update()
    {
        _t += Time.deltaTime;
        if(_t >= speedUp)
        {
            if (GetComponent<MainClass>().speed < maxSpeed)
                GetComponent<MainClass>().speed += 0.01f;
            _t = 0f;
        }
    }
}
