using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MawScript : MonoBehaviour
{
    public Transform target;

    public float speed = 5f;

    public float originX;
    public float originY;
    public float originZ;

    private void Awake()
    {
        transform.position = new Vector3(originX, originY, originZ);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InvokeRepeating("FollowPlayer",30f,2f);
    }

    public void FollowPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}
