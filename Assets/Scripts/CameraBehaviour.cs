﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{

    public Transform transform;
    public Transform playerTransform;

    public float cameraOffsetX;
    public float cameraOffsetY;

    public float zoomSpeed = 1;
    public float targetOrtho = 5.0f;
    public float smoothSpeed = 2.0f;
    public float minOrtho = 1.0f;
    public float maxOrtho = 20.0f;

    public bool transitioning = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    private void Update()
    {

        if (!transitioning)
        {

            Vector3 temp = transform.position;
            temp.x = playerTransform.position.x;
            temp.y = playerTransform.position.y;

            temp.x += cameraOffsetX;
            temp.y += cameraOffsetY;
            transform.position = temp;
        }  
       

    }
}
