using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deadWall1 : MonoBehaviour {
    public GameObject deadWall;
    Vector3 deadWallPosition;
    Vector3 deadWallPosition2;
    // Use this for initialization
    void Start () {
        deadWallPosition = new Vector3(-90.4f, -90.9f, 113.9f);
        deadWallPosition2 = new Vector3(-172.4f, -90.9f, 113.9f);
    }
	
	// Update is called once per frame
	void Update () {

    }
}
