﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float maxSpeed = 1f;
    public float speed = 1f;
    private Rigidbody2D rigidBodyEnemy;
    void Start()
    {
        rigidBodyEnemy = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidBodyEnemy.AddForce(Vector2.right * speed);
        float limitedSpeed = Mathf.Clamp(rigidBodyEnemy.velocity.x, -maxSpeed, maxSpeed);
        rigidBodyEnemy.velocity = new Vector2(limitedSpeed, rigidBodyEnemy.velocity.y);
   
        if(rigidBodyEnemy.velocity.x > -0.01f && rigidBodyEnemy.velocity.x < 0.01f){
            speed = -speed; 
            rigidBodyEnemy.velocity = new Vector2(speed, rigidBodyEnemy.velocity.y);
        }

        if(speed < 0){
            transform.localScale = new Vector3(1f, 1f, 1f);        
        } else if (speed > 0){
            transform.localScale = new Vector3(-1f, 1f, 1f);        
        }
    }
   
}
