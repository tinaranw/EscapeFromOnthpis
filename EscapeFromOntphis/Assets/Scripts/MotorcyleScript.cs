﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotorcyleScript : MonoBehaviour
{

    public float motorSpeed;
    Vector3 position;
    public float maxPos = 0.9f;

    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        position.y += Input.GetAxis ("Vertical") * motorSpeed * Time.deltaTime;

        position.y = Mathf.Clamp(position.y, -2.5f,  0.9f);

        transform.position = position;
    }
}