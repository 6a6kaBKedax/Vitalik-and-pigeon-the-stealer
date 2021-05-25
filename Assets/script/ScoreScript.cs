using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreScript : MonoBehaviour
{
    public Text text;

    // Update is called once per frame
    void Update()
    {
        text.text = Mathf.RoundToInt(transform.position.y).ToString();
        GlobalVariable.score = Mathf.RoundToInt(transform.position.y);
    }
}
