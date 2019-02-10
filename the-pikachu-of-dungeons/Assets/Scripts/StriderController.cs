using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StriderController : MonoBehaviour {
    private Rigidbody2D rb;
    public PCController player;

    // Use this for initialization
    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<PCController>();
    }

    // Update is called once per frame
    public void Update()
    {
        
    }

}
