﻿using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
    public float speed;
    public GameObject target;       //Public variable to store a reference to the player game object
    private Vector3 offset;         //Private variable to store the offset distance between the player and camera

    // Use this for initialization
    void Start() {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        offset = transform.position - target.transform.position;
    }

    // LateUpdate is called after Update each frame
    void LateUpdate() {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
    transform.position = Vector3.Lerp(transform.position,target.transform.position + offset, Time.deltaTime*speed);
    }

    public void SetTarget(GameObject newTarget) { target = newTarget; }
}