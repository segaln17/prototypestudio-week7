using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    private Rigidbody rb;

    public float speed = 5f;

    private Vector3 playerInput;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        playerInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }

    private void FixedUpdate()
    {
        rb.MovePosition(transform.position + playerInput * Time.deltaTime * speed);
        //transform.localScale *= 0.9f;
        //TODO: FIX THIS
    }
}
