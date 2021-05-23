﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformer : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float moveBy = x * speed;
        if (Mathf.Abs(rb.velocity.x) < 4)
        {
            rb.velocity += new Vector2(moveBy, 0);
        }
    }
}
