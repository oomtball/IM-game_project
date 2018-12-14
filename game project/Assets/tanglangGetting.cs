using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tanglangGetting : MonoBehaviour {
    public static Transform player;
    public static GameObject pivot;
    public static GameObject goal;
    public GameObject lab;
    public static bool gettingTanglang = false;
    public static GameObject tanglang;
    public static bool canGetThis = true;
    Vector3 prePos;
    //Rigidbody body;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
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
        }
    }
    private void OnMouseDown()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        if (gettingTanglang == false && dist <= 30)
        {
            tanglang.transform.position = goal.transform.position;
            gettingTanglang = true;
            tanglang.GetComponent<Rigidbody>().useGravity = false;
        }
    }
}
