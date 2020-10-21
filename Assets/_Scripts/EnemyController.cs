/*
 Filename: EnemyController.cs
 Author: Salick Talhah
 Student Number: 101214166
 Date last modified: 20/10/2020
 Description: This file control the enemy movements.
 Revision History:
 20/10/2020
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //public float horizontalSpeed;
    //public float horizontalBoundary;
    public float direction;
    public float verticalSpeed;
    public float verticalBoundary;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        // setting the vertical speed (y axis) for the enemy.
        transform.position += new Vector3(0.0f, verticalSpeed * direction * Time.deltaTime, 0.0f);
    }

    private void _CheckBounds()
    {
        // check up boundary
        if (transform.position.y >= verticalBoundary)
        {
            direction = -1.0f;
        }

        // check down boundary
        if (transform.position.y <= -verticalBoundary)
        {
            direction = 1.0f;
        }
    }
}
