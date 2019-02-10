using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float timer;
    private float elapsed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsed = elapsed + Time.deltaTime;
        if ( elapsed > timer ){
            Destroy(gameObject);
        }
    }
}
