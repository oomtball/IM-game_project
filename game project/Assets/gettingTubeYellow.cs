using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gettingTubeYellow : MonoBehaviour {
    public static Transform player;
    public static GameObject pivot;
    public static GameObject goal;
    public GameObject testTube;
    public GameObject item;
    public static bool tubeYellow = false;
    Vector3 prePos;
    //Rigidbody body;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        pivot = GameObject.Find("pivot");
        goal = GameObject.Find("goal");

        //body = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (tubeYellow)
        {
            item.transform.SetParent(pivot.transform, true);
        }
        if (Input.GetMouseButton(1) && tubeYellow)
        {
            tubeYellow = false;
            item.transform.SetParent(testTube.transform, true);
            item.GetComponent<Rigidbody>().useGravity = true;
            item.GetComponent<Rigidbody>().isKinematic = false;
            item.GetComponent<Rigidbody>().detectCollisions = true;
        }
    }
    private void OnMouseDown()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        if (tubeYellow == false && !gettingTubeRed.tubeRed && !gettingTubeBlue.tubeBlue && !gettingTubeGreen.tubeGreen && dist <= 30)
        {
            item.transform.position = goal.transform.position;
            item.GetComponent<Rigidbody>().useGravity = false;
            tubeYellow = true;
            item.GetComponent<Rigidbody>().isKinematic = true;
            item.GetComponent<Rigidbody>().detectCollisions = false;
            //item.GetComponent<Rigidbody>().useGravity = false;
        }
    }
}
