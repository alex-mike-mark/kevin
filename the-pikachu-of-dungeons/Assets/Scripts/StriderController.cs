using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StriderController : MonoBehaviour {
    private AudioSource narrateDeath;
    private Renderer rend;
    private AudioSource nc;
    private Collider2D coll2d;
    
    public void Start()
    {
        nc = GameObject.Find("NarrationController").GetComponent<AudioSource>();
        narrateDeath = GetComponent<AudioSource>();
        coll2d = GetComponent<Collider2D>();
        rend = GetComponent<Renderer>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if ( other.gameObject.tag == "Bullet"){
            StartCoroutine(Die());
        }
    }

    //Needs to wait and play sound before destroying
    IEnumerator Die()
    {
        coll2d.enabled = false;
        if(!nc.isPlaying){
            narrateDeath.Play();
        }
        
        rend.enabled = false;
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}
