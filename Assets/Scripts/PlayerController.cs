using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private Rigidbody2D mainRigidBody;
    [SerializeField] private SpriteRenderer mainSpriteRenderer;
    [SerializeField] private float moveSpeed;

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            mainRigidBody.AddForce(new Vector2(-moveSpeed * Time.deltaTime, 0));
            mainSpriteRenderer.flipX = true;
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            mainRigidBody.AddForce(new Vector2(moveSpeed * Time.deltaTime, 0));
            mainSpriteRenderer.flipX = false;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space))
        {
            mainRigidBody.AddForce(new Vector2(0, 6000));
        }
    }
}
