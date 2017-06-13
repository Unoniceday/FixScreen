﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSizeScreen : MonoBehaviour {


    public float baseWidth = 1024;
    public float baseHeight = 768;
    public float baseOrthographicSize = 5;

    void Awake()
    {
        float newOrthographicSize = (float)Screen.height / (float)Screen.width * this.baseWidth / this.baseHeight * this.baseOrthographicSize;
        Camera.main.orthographicSize = Mathf.Max(newOrthographicSize, this.baseOrthographicSize);

    }

  
}
