using UnityEngine;
using UnityEngine.SceneManagement;

public class AccelDoodle : MonoBehaviour
{
    public static AccelDoodle insance;
    public Rigidbody2D Doodle;

    private void Start()
    {
        if (insance == null)
        {
            insance = this;
        }

    }
    void FixedUpdate()
    {
        Doodle.velocity = new Vector2(Input.acceleration.x * 20f, Doodle.velocity.y);
        Doodle.freezeRotation = true;

        if (transform.position.x < -2.31)
            transform.position = new Vector2(transform.position.x + 4f, transform.position.y);
        else if (transform.position.x > 2.31)
            transform.position = new Vector2(transform.position.x - 4f, transform.position.y);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Finish")
            SceneManager.LoadScene("Game");
    }
}
