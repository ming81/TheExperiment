﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixScale : MonoBehaviour
{
    public Vector3 scale;
    private Vector3 lossyScale;

    private void Awake()
    {
        lossyScale = transform.lossyScale;
    }

    private void LateUpdate()
    {
        transform.localScale = new Vector3(
            scale.x / lossyScale.x,
            scale.y / lossyScale.y,
            scale.z / lossyScale.z);
    }
}
