using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class spiderKeyGetting : MonoBehaviour {
    public static Transform player;
    public static bool gettingSpider = false;
    public static GameObject spiderKey;
    public static bool canGetThis = true;
    Vector3 prePos;
    //Rigidbody body;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        spiderKey = GameObject.Find("spiderKey");
        //body = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (gettingSpider && canGetThis)
        {
            Vector3 mouse = Input.mousePosition;
            mouse.z = 10;
            Vector3 newPos = Camera.main.ScreenToWorldPoint(mouse);
            Vector3 offset = newPos - prePos;
            transform.position += offset;
            prePos = Camera.main.ScreenToWorldPoint(mouse);
        }
        if (Input.GetMouseButton(1) && gettingSpider)
        {
            gettingSpider = false;
        }
    }
    private void OnMouseDown()
    {
        //float dist = Vector3.Distance(player.position, transform.position);
        if (gettingSpider == false)
        {
            Vector3 mouse = Input.mousePosition;
            mouse.z = 10;
            prePos = Camera.main.ScreenToWorldPoint(mouse);

            gettingSpider = true;
            //item.GetComponent<Rigidbody>().useGravity = false;
        }
    }
}
