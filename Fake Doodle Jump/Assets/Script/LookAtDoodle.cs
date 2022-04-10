using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtDoodle : MonoBehaviour
{
    public Transform Doodle;
    private void Update()
    {
        if (Doodle.position.y > transform.position.y)
            transform.position = new Vector3(transform.position.x, Doodle.position.y, transform.position.z);
    }
}
