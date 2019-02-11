using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float timer;
    private float elapsed;
    private Transform tf;
    private Renderer rend;

    private BoxCollider2D col;

    void Start()
    {
        rend = GetComponent<Renderer>();
        col = GetComponent<BoxCollider2D>();
        tf = gameObject.GetComponent<Transform>();
        tf.Translate(tf.forward*200);
    }

    // Update is called once per frame
    void Update()
    {
        elapsed = elapsed + Time.deltaTime;
        if ( elapsed > timer ){
            StartCoroutine(Despawn());
        }
    }

    IEnumerator Despawn()
    {
        rend.enabled = false;
        col.enabled = false;
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}
