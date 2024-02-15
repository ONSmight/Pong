using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    Vector2 col;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0f, 0f, 0f);
        //StartCoroutine(Wait(2f));
        Invoke("Shoot", 2f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag=="Player")
        {
            col = rb.velocity;
            col.y= rb.velocity.y + collision.collider.attachedRigidbody.velocity.y / 3;
            rb.velocity = col;
            gameObject.GetComponent<AudioSource>().Play();
        }
    }

    void Shoot()
    {
        rb = GetComponent<Rigidbody2D>();
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(x * speed, y * speed);
    }
    public void Respawn(float sec=0.5f)
    {
        rb.velocity = new Vector2(0f, 0f);
        transform.position = new Vector3(0f, 0f, 0f);
        // StartCoroutine(Wait(0.5f));
        Invoke("Shoot", sec);
    }

   /* IEnumerator Wait(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        Shoot();
    }*/
}
