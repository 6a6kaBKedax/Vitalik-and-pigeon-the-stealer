using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI : MonoBehaviour
{

    public Slider sl;
    // Start is called before the first frame update
    void Start()
    {
        sl.minValue = GlobalVariable.hardLevel / 100f;
        sl.value = GlobalVariable.hardLevel/100f;
    }

    public void updateData()
    {
        
        GetComponent<Text>().text = Mathf.RoundToInt(sl.value*100f)+"%";
        GlobalVariable.hardLevel = Mathf.RoundToInt(sl.value * 100f);
        
    }
}
public class GlobalVariable
{
    public static int hardLevel = 30;
    public static int score;
}
