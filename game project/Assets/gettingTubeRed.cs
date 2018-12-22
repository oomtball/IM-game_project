using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gettingTubeRed : MonoBehaviour {
    public static Transform player;
    public static GameObject pivot;
    public static GameObject goal;
    public GameObject testTube;
    public GameObject item;
    public static bool tubeRed = false;
    Vector3 prePos;
    //Rigidbody body;
    private void Awake()
    {
        pivot = GameObject.Find("pivot");
        goal = GameObject.Find("goal");
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        //body = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (tubeRed)
        {
            item.transform.SetParent(pivot.transform, true);
        }
        if (Input.GetMouseButton(1) && tubeRed)
        {
            tubeRed = false;
            item.transform.SetParent(testTube.transform, true);
            item.GetComponent<Rigidbody>().useGravity = true;
            item.GetComponent<Rigidbody>().isKinematic = false;
            item.GetComponent<Rigidbody>().detectCollisions = true;
        }
    }
    private void OnMouseDown()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        if (tubeRed == false && dist <= 30)
        {
            item.transform.position = goal.transform.position;
            item.GetComponent<Rigidbody>().useGravity = false;
            tubeRed = true;
            item.GetComponent<Rigidbody>().isKinematic = true;
            item.GetComponent<Rigidbody>().detectCollisions = false;
            //item.GetComponent<Rigidbody>().useGravity = false;
        }
    }
}
