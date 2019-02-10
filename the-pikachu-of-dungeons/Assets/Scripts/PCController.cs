using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCController : MonoBehaviour
{
    public float accel;
    public float maxSpeed;

    private Rigidbody2D rb;
    private SpriteRenderer sr;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float v = Input.GetAxisRaw("Vertical");
        float h = Input.GetAxisRaw("Horizontal");
        bool f = Input.GetButtonDown("Fire1");

        // calc parts of new velocity vector.
        float nh = h != 0 ? boundValue(rb.velocity.x + accel*h,maxSpeed,-maxSpeed) : 0;
        float nv = v != 0 ? boundValue(rb.velocity.y + accel*v,maxSpeed,-maxSpeed) : 0;

        // determine sprite facing
        if ( nh != 0 ){
            sr.flipX = nh > 0 ? true : false;
        }

        rb.velocity = new Vector2(nh,nv);
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        
    }

    // if value is bigger than top, set to top.
    // if value is smaller than bottom, set to bottom.
    // else don't change value
    private float boundValue(float value, float top, float bottom){
        return Mathf.Max(Mathf.Min(value,top),bottom);
    }
}
