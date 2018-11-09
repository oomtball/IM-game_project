using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canGetIt : MonoBehaviour {

    Vector3 prePos;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnMouseDown() {
        Vector3 mouse = Input.mousePosition;
        mouse.z = 10;
        prePos = Camera.main.ScreenToWorldPoint(mouse);
    }

    private void OnMouseDrag()
    {
        Vector3 mouse = Input.mousePosition;
        mouse.z = 10;
        Vector3 newPos = Camera.main.ScreenToWorldPoint(mouse);
        Vector3 offset = newPos - prePos;
        transform.position += offset;
        prePos = Camera.main.ScreenToWorldPoint(mouse);
    }
}
