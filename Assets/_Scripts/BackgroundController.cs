/*
 Filename: BackgroundController.cs
 Author: Salick Talhah
 Student Number: 101214166
 Date last modified: 20/10/2020
 Description: This file has the Background scrolling details
 Revision History:
 20/10/2020
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    //public float verticalSpeed;
   // public float verticalBoundary;
    public float horizontalSpeed;
    public float horizontalBoundary;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Reset()
    {
        //reseting the BG depending on x axis position
        transform.position = new Vector3(horizontalBoundary,0.0f);
    }

    private void _Move()
    {
        //moving speed of BG on the x axis since it is landscape
        transform.position -= new Vector3(horizontalSpeed,0.0f) * Time.deltaTime; 
    }

    private void _CheckBounds()
    {
        // if the background is lower than the bottom of the screen then reset
        if (transform.position.x <= -horizontalBoundary)
        {
            _Reset();
        }
    }
}
