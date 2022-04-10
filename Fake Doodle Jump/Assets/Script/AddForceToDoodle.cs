using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceToDoodle : MonoBehaviour
{

    private float jump = 10;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && collision.relativeVelocity.y < 0)
            AccelDoodle.insance.Doodle.velocity = transform.up * jump;

        if (collision.gameObject.tag == "Finish")
            gameObject.transform.position = new Vector2(Random.Range(-1.55f, 1.55f), Random.Range(transform.position.y + 14f, transform.position.y + 16f));

    }
}
