﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlastPath : MonoBehaviour {

    SpriteRenderer sr;
    
    public GameObject bullet;
	void Start () 
    {
        sr = GetComponentInParent<SpriteRenderer>();	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (sr.flipX == false)
            {
                bullet.GetComponent<Blast_Trajectory>().direction = Vector2.right;
                Instantiate(bullet, this.transform);
            }
            else
            {
                bullet.GetComponent<Blast_Trajectory>().direction = Vector2.left;
                Instantiate(bullet, this.transform);
            }
            
        }
	}
}
