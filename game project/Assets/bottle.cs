using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class bottle : MonoBehaviour {
    public static Transform player;
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    public static GameObject pivot;
    public static GameObject goal;
    public static bool gettingBottle = false;
    public static GameObject bottle1;
    public GameObject paperInBottle;
    public static bool canGetThis = true;
    int count;
    Vector3 prePos;
    //Rigidbody body;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        pivot = GameObject.Find("pivot");
        goal = GameObject.Find("goal");
        bottle1 = GameObject.Find("bottle");
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
        count = 0;
        bottle1.SetActive(false);
    }
    private void Update()
    {
        if (gettingBottle && canGetThis)
        {
            bottle1.transform.SetParent(pivot.transform, true);
        }
        if (Input.GetMouseButton(1) && gettingBottle)
        {
            gettingBottle = false;
            bottle1.transform.SetParent(null);
            bottle1.GetComponent<Rigidbody>().useGravity = true;
            bottle1.GetComponent<Rigidbody>().isKinematic = false;
            bottle1.GetComponent<Rigidbody>().detectCollisions = true;
        }
    }
    private void OnMouseDown()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        if (gettingBottle == false && dist <= 30 && canGetThis)
        {
            talkFlowchart.ExecuteBlock("paperInBottle");
            bottle1.transform.position = goal.transform.position;
            if (count == 0)
            {
                bottle1.AddComponent<Rigidbody>();
                count += 1;
            }
            bottle1.GetComponent<Rigidbody>().freezeRotation = true;
            bottle1.GetComponent<Rigidbody>().useGravity = false;
            bottle1.GetComponent<Rigidbody>().isKinematic = true;
            bottle1.GetComponent<Rigidbody>().detectCollisions = false;
            gettingBottle = true;
        }
    }
}
