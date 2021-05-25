using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class DamageScript : MonoBehaviour
{
    public Material mat;
    public Color DamageColor;
    public float DamageFlow;
    public bool _isActive;

    private float _t;

    private int lives = 3;
    public Image[] hearts;
    public Sprite emptyHearts;
    void FixedUpdate()
    {
        if(_isActive && _t < DamageFlow)
        {
            _t += Time.deltaTime;
            mat.color = DamageColor;
        }else
        {
            mat.color = Color.white;
            _isActive = false;
            _t = 0f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "kiler" || collision.tag == "rock")
        {
            _isActive = true;
            changeHeart();
        }
    }

    private void changeHeart()
    {
        lives -= 1;
        if(lives == 0)
        {
            SceneManager.LoadScene(2);
        }
        for (int i = 0; i < 3 - lives; i++)
        {
            hearts[Mathf.Abs(i - 2)].sprite = emptyHearts;
        }
        
    }
}
