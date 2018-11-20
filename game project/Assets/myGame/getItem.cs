using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class getItem : MonoBehaviour {
    public static Transform player;
    public static bool isGettingItem = false;
    public GameObject item;
    Vector3 prePos;
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
            Vector3 mouse = Input.mousePosition;
            mouse.z = 10;
            Vector3 newPos = Camera.main.ScreenToWorldPoint(mouse);
            Vector3 offset = newPos - prePos;
            transform.position += offset;
            prePos = Camera.main.ScreenToWorldPoint(mouse);
        }
        if (Input.GetMouseButton(1)){
            isGettingItem = false;
            item.GetComponent<Rigidbody>().useGravity = true;
        }
    }
    private void OnMouseDown()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        Debug.Log(dist);
        if (isGettingItem == false && dist <= 30)
        {
            Vector3 mouse = Input.mousePosition;
            mouse.z = 10;
            prePos = Camera.main.ScreenToWorldPoint(mouse);

            isGettingItem = true;
            item.GetComponent<Rigidbody>().useGravity = false;
        }
    }
}
