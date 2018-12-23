using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class tanglangGetting : MonoBehaviour {
    public static Transform player;
    public static GameObject pivot;
    public static GameObject goal;
    public static Flowchart talkFlowchart;

    public GameObject lab;
    public static bool gettingTanglang = false;
    public static GameObject tanglang;
    public static bool canGetThis = true;
    Vector3 prePos;
    //Rigidbody body;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
        tanglang = GameObject.Find("tanglang");
        pivot = GameObject.Find("pivot");
        goal = GameObject.Find("goal");
    }
    private void Update()
    {
        if (gettingTanglang)
        {
            tanglang.transform.SetParent(pivot.transform, true);
        }
        if (Input.GetMouseButton(1) && gettingTanglang)
        {
            gettingTanglang = false;
            tanglang.transform.SetParent(lab.transform, true);
            tanglang.GetComponent<Rigidbody>().useGravity = true;
            tanglang.GetComponent<Rigidbody>().isKinematic = false;
            tanglang.GetComponent<Rigidbody>().detectCollisions = true;
        }
    }
    private void OnMouseDown()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        if (gettingTanglang == false && dist <= 30)
        {
            if (!elecOpen.isLight)
            {
                talkFlowchart.ExecuteBlock("noTouch");
            }
            else
            {
                tanglang.transform.position = goal.transform.position;
                gettingTanglang = true;
                tanglang.GetComponent<Rigidbody>().useGravity = false;
                tanglang.GetComponent<Rigidbody>().isKinematic = true;
                tanglang.GetComponent<Rigidbody>().detectCollisions = false;
            }
        }
    }
}
