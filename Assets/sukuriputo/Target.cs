﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Harpy");
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(target.transform.position);
    }
}
