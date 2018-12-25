using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class butterKeyGetting : MonoBehaviour {
    public static Transform player;
    public static GameObject pivot;
    public static GameObject goal;
    public GameObject girlC;
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    public static bool gettingButterfly = false;
    public static GameObject butterKey;
    public static bool canGetThis = true;
    Vector3 prePos;
    //Rigidbody body;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        butterKey = GameObject.Find("butterflyKey");
        pivot = GameObject.Find("pivot");
        goal = GameObject.Find("goal");
        butterKey.SetActive(false);
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
    }
    private void Update()
    {
        if (gettingButterfly && canGetThis)
        {
            butterKey.transform.SetParent(pivot.transform, true);
        }
        if (Input.GetMouseButton(1) && gettingButterfly)
        {
            gettingButterfly = false;
            butterKey.transform.SetParent(girlC.transform, true);
            butterKey.GetComponent<Rigidbody>().useGravity = true;
            butterKey.GetComponent<Rigidbody>().isKinematic = false;
            butterKey.GetComponent<Rigidbody>().detectCollisions = true;
        }
    }
    private void OnMouseDown()
    {
        talkFlowchart.ExecuteBlock("getButterflyKey");
        float dist = Vector3.Distance(player.position, transform.position);
        if (gettingButterfly == false && canGetThis && dist <= 30)
        {
            butterKey.transform.position = goal.transform.position;
            butterKey.GetComponent<Rigidbody>().useGravity = false;
            gettingButterfly = true;
            butterKey.GetComponent<Rigidbody>().isKinematic = true;
            butterKey.GetComponent<Rigidbody>().detectCollisions = false;
        }
    }
}
