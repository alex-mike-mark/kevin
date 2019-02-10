using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCController : MonoBehaviour
{
    // Start is called before the first frame update
    public float accel;
    public float maxSpeed;

    private Rigidbody2D rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Seems like controls are gonna be something like
    // wasd or whatever to move
    // and then some fire key to shoot. So like 5 inputs?
    // get two axes, get one button.
    void Update()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");
        bool f = Input.GetButtonDown("Fire1");

        float nv = v != 0 ? boundValue(accel*v,maxSpeed,-maxSpeed) : 0;
        float nh = h != 0 ? boundValue(accel*h,maxSpeed,-maxSpeed) : 0;

        rb.velocity = new Vector2(nh,nv);
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        
    }

    private float boundValue(float value, float top, float bottom){
        Debug.Log("Top: "+top+" Value: "+value+" Bottom: "+bottom);
        return Mathf.Max(Mathf.Min(value,top),bottom);
    }
}
