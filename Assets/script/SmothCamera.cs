using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmothCamera : MonoBehaviour
{
    public Vector3 needPosition;
    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, needPosition, 0.1f);
    }
}
