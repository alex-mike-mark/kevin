using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StriderController : MonoBehaviour {

    
    private void OnTriggerEnter2D(Collider2D other) {
        if ( other.gameObject.tag == "Bullet"){
            Die();
        }
    }

    private void Die(){
        Destroy(gameObject);
    }
}
