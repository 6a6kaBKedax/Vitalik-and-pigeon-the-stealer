using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructor : MonoBehaviour
{
    private void FixedUpdate()
    {
        
        foreach (GameObject item in UnityEngine.Object.FindObjectsOfType<GameObject>())
        {
            if(item.transform.position.y + 10 <= transform.position.y & item.tag != "doNotDelete")
            {
                Destroy(item);
            }
        }
    }
}
