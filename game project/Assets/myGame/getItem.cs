using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class getItem : MonoBehaviour {
    public static Transform player;
    public GameObject pivot;
    public GameObject goal;
    public static bool isGettingItem = false;
    public GameObject item;
    Rigidbody body;
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        body = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (isGettingItem)
        {
            item.transform.SetParent(pivot.transform, true);
        }
        if (Input.GetMouseButton(1) && isGettingItem){
            isGettingItem = false;
            item.GetComponent<Rigidbody>().useGravity = true;
            item.transform.SetParent(null);
        }
    }
    private void OnMouseDown()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        if (isGettingItem == false && dist <= 30)
        {
            item.transform.position = goal.transform.position;
            isGettingItem = true;
            item.GetComponent<Rigidbody>().useGravity = false;
        }
    }
}
