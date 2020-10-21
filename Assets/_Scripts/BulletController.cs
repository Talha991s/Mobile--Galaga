/*
 Filename: BulletController.cs
 Author: Salick Talhah
 Student Number: 101214166
 Date last modified: 20/10/2020
 Description: This file control the speed and boundary of the bullets in the scene
 Revision History:
 20/10/2020
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour, IApplyDamage
{
   // public float verticalSpeed;
   // public float verticalBoundary;
    public BulletManager bulletManager;
    public float horizontalSpeed;   
    public float horizontalBoundary;
    public int damage;
    
    // Start is called before the first frame update
    void Start()
    {
        bulletManager = FindObjectOfType<BulletManager>();
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        transform.position += new Vector3(horizontalSpeed,0.0f, 0.0f) * Time.deltaTime;  //since it is landscape we are using x axis to move the bullet
    }

    private void _CheckBounds()
    {
         // checking if the bullet is still in the scene range or hit an enemy
        if (transform.position.x > horizontalBoundary)
        {
            bulletManager.ReturnBullet(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(other.gameObject.name);
        bulletManager.ReturnBullet(gameObject);  // bullet hit the enemy 
    }

    public int ApplyDamage()
    {
        // confirming damage
        return damage;
    }
}
