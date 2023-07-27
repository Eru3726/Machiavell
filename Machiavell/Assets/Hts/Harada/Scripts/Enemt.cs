using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemt : MonoBehaviour
{
    private Rigidbody2D rb2d;
    Animator animator;    //アニメーター

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
