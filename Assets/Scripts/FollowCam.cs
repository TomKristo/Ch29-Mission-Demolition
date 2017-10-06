﻿using System.Collections;
using UnityEngine;

public class FollowCam : MonoBehaviour {
    static public FollowCam S;
    public float easing = 0.05f;
    public Vector2 minXY;
    public bool ________________;
    public GameObject poi;
    public float camZ;

    private void Awake()
    {
        S = this;
        camZ = this.transform.position.z;
    }

    private void Update()
    {
        if (poi == null) return;

        Vector3 destination = poi.transform.position;
        destination.x = Mathf.Max( minXY.x, destination.x);
        destination.y = Mathf.Max( minXY.y, destination.y); 
        destination = Vector3.Lerp(transform.position, destination, easing);
        destination.z = camZ;
        transform.position = destination;
        this.GetComponent<Camera>().orthographicSize = destination.y + 10;
    }
}
