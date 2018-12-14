using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballWall : MonoBehaviour {
    public GameObject ball;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnCollisionEnter(Collision ball)
    {
        ball.transform.position = new Vector3(122, 124, 69.7f);
    }
}
