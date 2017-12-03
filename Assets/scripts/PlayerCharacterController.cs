﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using UnityEngine;

public class PlayerCharacterController : MonoBehaviour
{
    private Animator animator;

    private GameObject player;

    private bool walking;
    private int orientation;

    public float speed;

    // Direction constants
    private const int _NORTH = 2;
    private const int _SOUTH = 0;
    private const int _WEST = 1;
    private const int _EAST = 3;

    // Use this for initialization
    void Start()
    {
        animator = this.GetComponent<Animator>();
        player = GameObject.FindWithTag("Player");

        walking = false;
        orientation = _SOUTH;
    }

    // Update is called once per frame
    void Update()
    {
        var vertical = Input.GetAxisRaw("Vertical");
        var horizontal = Input.GetAxisRaw("Horizontal");
        
        walking = Math.Abs(vertical) != 0 || Math.Abs(horizontal) != 0;
        
        animator.SetBool("walking", walking);
        animator.SetInteger("direction", orientation);
    }

    private void FixedUpdate()
    {
        var vertical = Input.GetAxisRaw("Vertical");
        var horizontal = Input.GetAxisRaw("Horizontal");
        var input = new Vector2(horizontal, vertical);
        var transformDirection = transform.TransformDirection(input * speed * Time.deltaTime);
        
        player.GetComponent<CharacterController>().Move(transformDirection);
        
        if (!walking) {
            // TODO - figure out how to stop animation
        }
        
        if (vertical > 0) {
            orientation = _NORTH;
        } else if (vertical < 0) {
            orientation = _SOUTH;
        } else if (horizontal > 0) {
            orientation = _EAST;
        } else if (horizontal < 0) {
            orientation = _WEST;
        }
    }
    
    public void OnCollisionEnter(Collision col) 
    {
//        if (col.gameObject.CompareTag("Enemy")) {
//            animator.SetTrigger("Die");
//        }
    }
}
