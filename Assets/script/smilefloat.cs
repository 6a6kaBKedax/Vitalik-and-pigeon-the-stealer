using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class smilefloat : MonoBehaviour
{
  
    public Sprite spritesmale;
    public Sprite spritessad;
    public Sprite spriteangry;
    public Slider sl;

    public void Update()
    {
        if(sl.value < 0.35f)
        {
            GetComponent<SpriteRenderer>().sprite = spritesmale;
        }
        if(sl.value >= 0.36f && sl.value < 0.66f)
        {
            GetComponent<SpriteRenderer>().sprite = spritessad;
        }
        if(sl.value >= 0.67f)
        {
            GetComponent<SpriteRenderer>().sprite = spriteangry;
        }
    }
}
