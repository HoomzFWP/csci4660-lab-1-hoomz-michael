using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float duration;
    [SerializeField] private Transform mainTransform;

    void Start()
    {
        StartCoroutine(fireRoutine());
    }
    IEnumerator fireRoutine()
    {
        float elapsedTime = 0;
        while (elapsedTime <= duration)
        {
            elapsedTime += Time.deltaTime;
            mainTransform.position += mainTransform.up * moveSpeed * Time.deltaTime;
            yield return null;
        }
        Destroy(gameObject);
    }
}