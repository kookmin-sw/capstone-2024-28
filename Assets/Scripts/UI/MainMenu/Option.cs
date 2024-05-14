﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option : MonoBehaviour
{
    public Vector3 originalScale;

    void Start()
    {
        originalScale = transform.localScale; 
        SetScale(Vector3.zero); 
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleScale(); 
        }
    }

    void ToggleScale()
    {
        if (transform.localScale == Vector3.zero)
        {
            SetScale(originalScale); 
        }
        else
        {
            SetScale(Vector3.zero); 
        }
    }

    void SetScale(Vector3 scale)
    {
        transform.localScale = scale;
    }
    public void ButtonClicked()
    {
        ToggleScale();
    }
}
