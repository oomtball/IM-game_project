using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiderKeyGetting : MonoBehaviour {
    public static Transform player;
    public static GameObject pivot;
    public static GameObject goal;
    public GameObject girlC;
    public static bool gettingSpider = false;
    public static GameObject spiderKey;
    public static bool canGetThis = true;
    int count;
    Vector3 prePos;
    //Rigidbody body;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        pivot = GameObject.Find("pivot");
        goal = GameObject.Find("goal");
        spiderKey = GameObject.Find("spiderKey");
        count = 0;
        //spiderKey.GetComponent<Rigidbody>().detectCollisions = true;
        //body = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (gettingSpider && canGetThis)
        {
            spiderKey.transform.SetParent(pivot.transform, true);
        }
        if (Input.GetMouseButton(1) && gettingSpider)
        {
            gettingSpider = false;
            spiderKey.transform.SetParent(girlC.transform, true);
            spiderKey.GetComponent<Rigidbody>().useGravity = true;
            spiderKey.GetComponent<Rigidbody>().isKinematic = false;
            spiderKey.GetComponent<Rigidbody>().detectCollisions = true;
        }
    }
    private void OnMouseDown()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        if (gettingSpider == false && dist <= 30 && canGetThis)
        {
            spiderKey.transform.position = goal.transform.position;
            if (count == 0)
            {
                spiderKey.AddComponent<Rigidbody>();
                count += 1;
            }
            spiderKey.GetComponent<Rigidbody>().freezeRotation = true;
            spiderKey.GetComponent<Rigidbody>().useGravity = false;
            spiderKey.GetComponent<Rigidbody>().isKinematic = true;
            spiderKey.GetComponent<Rigidbody>().detectCollisions = false;
            gettingSpider = true;
        }
    }
}
