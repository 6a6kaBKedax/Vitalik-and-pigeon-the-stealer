using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//using UnityEngine.UI;

public class MainClass : MonoBehaviour
{
    public float speed = 20;
    public bool _disabled = false;
    //public static float speed = GlobalVar.mejduspeed;
    private SmothCamera camera;

    private void Start()
    {
        camera = GetComponent<SmothCamera>();
    }


    void FixedUpdate()
    {
        if(!_disabled)
            camera.needPosition = new Vector3(0, camera.needPosition.y + speed, -4);
    }
}

/*
public static class GlobarVar
{
    
    public static InputField mainInputField;
    public static InputField field;
    public static int mejduspeed = field.text;
    
}
*/