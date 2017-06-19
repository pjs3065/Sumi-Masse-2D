﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBall1Controller : MonoBehaviour {

    public float speed;
    private Rigidbody rigidbody;
    private bool isMoving;

    // Use this for initialization
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        StartCoroutine(CheckMoving(0.05f));
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator CheckMoving(float checkRate)
    {
        Vector3 prevPos, actualPos;

        while (true)
        {
            prevPos = rigidbody.transform.position;
            yield return new WaitForSeconds(checkRate);
            actualPos = rigidbody.transform.position;
            if (prevPos == actualPos)
                isMoving = false;
            else
                isMoving = true;
        }
    }

    public bool IsMoving()
    {
        return isMoving;
    }
}
