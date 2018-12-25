using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class gettingTanglangKey : MonoBehaviour {
    public static Transform player;
    public static GameObject pivot;
    public static GameObject goal;
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    public GameObject girlC;
    public static bool gettingTanglang = false;
    public static GameObject tanglangKey;
    public static bool canGetThis = true;
    Vector3 prePos;
    //Rigidbody body;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        tanglangKey = GameObject.Find("tanglangKey");
        tanglangKey.SetActive(false);
        pivot = GameObject.Find("pivot");
        goal = GameObject.Find("goal");
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
    }
    private void Update()
    {
        if (gettingTanglang && canGetThis)
        {
            tanglangKey.transform.SetParent(pivot.transform, true);
        }
        if (Input.GetMouseButton(1) && gettingTanglang)
        {
            gettingTanglang = false;
            tanglangKey.transform.SetParent(girlC.transform, true);
            tanglangKey.GetComponent<Rigidbody>().useGravity = true;
            tanglangKey.GetComponent<Rigidbody>().isKinematic = false;
            tanglangKey.GetComponent<Rigidbody>().detectCollisions = true;
        }
    }
    private void OnMouseDown()
    {
        talkFlowchart.ExecuteBlock("getTanglangKey");
        float dist = Vector3.Distance(player.position, transform.position);
        if (gettingTanglang == false && dist <= 30 && canGetThis)
        {
            tanglangKey.transform.position = goal.transform.position;
            tanglangKey.GetComponent<Rigidbody>().useGravity = false;
            gettingTanglang = true;
            tanglangKey.GetComponent<Rigidbody>().isKinematic = true;
            tanglangKey.GetComponent<Rigidbody>().detectCollisions = false;
        }
    }
}
