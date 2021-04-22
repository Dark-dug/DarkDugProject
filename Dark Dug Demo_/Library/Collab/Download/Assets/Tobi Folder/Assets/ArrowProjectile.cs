using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowProjectile : MonoBehaviour
{
    //public float speed = 20f;
    // public Rigidbody2D rb;
    // Start is called before the first frame update
    public GameObject hitEffect;

    void Start()
    {
       // rb.velocity = transform.right * speed;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
