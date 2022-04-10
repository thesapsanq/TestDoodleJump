using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    private readonly float speed = 3f;
    bool reverseMove = true;
    public Rigidbody2D movingPlatform;

    private void FixedUpdate()
    {
        if (transform.position.x > 1.56)
            reverseMove = false;
        else if (transform.position.x < -1.56)
            reverseMove = true;


        if (reverseMove)
            movingPlatform.MovePosition(transform.position + speed * transform.right * Time.fixedDeltaTime);
        else
            movingPlatform.MovePosition(transform.position - speed * transform.right * Time.fixedDeltaTime);

    }
}
