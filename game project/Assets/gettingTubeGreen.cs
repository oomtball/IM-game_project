using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gettingTubeGreen : MonoBehaviour {
    public static Transform player;
    public static bool tubeGreen = false;
    Vector3 prePos;
    //Rigidbody body;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        //body = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (tubeGreen)
        {
            Vector3 mouse = Input.mousePosition;
            mouse.z = 10;
            Vector3 newPos = Camera.main.ScreenToWorldPoint(mouse);
            Vector3 offset = newPos - prePos;
            transform.position += offset;
            prePos = Camera.main.ScreenToWorldPoint(mouse);
        }
        if (Input.GetMouseButton(1) && tubeGreen)
        {
            tubeGreen = false;
        }
    }
    private void OnMouseDown()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        if (tubeGreen == false && dist <= 30)
        {
            Vector3 mouse = Input.mousePosition;
            mouse.z = 10;
            prePos = Camera.main.ScreenToWorldPoint(mouse);

            tubeGreen = true;
            //item.GetComponent<Rigidbody>().useGravity = false;
        }
    }
}
