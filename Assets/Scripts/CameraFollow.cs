using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField] private Transform mainTransform;
    [SerializeField] private Transform target;

    void FixedUpdate()
    {
        Vector3 currentPos = mainTransform.position;
        currentPos.x = target.position.x;
        mainTransform.position = currentPos;
    }
}
