using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class butterKeyGetting : MonoBehaviour {
    public static Transform player;
    public static bool gettingButterfly = false;
    public static GameObject butterKey;
    public static bool canGetThis = true;
    Vector3 prePos;
    //Rigidbody body;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        butterKey = GameObject.Find("butterflyKey");
        butterKey.SetActive(false);
        //body = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (gettingButterfly && canGetThis)
        {
            Vector3 mouse = Input.mousePosition;
            mouse.z = 10;
            Vector3 newPos = Camera.main.ScreenToWorldPoint(mouse);
            Vector3 offset = newPos - prePos;
            transform.position += offset;
            prePos = Camera.main.ScreenToWorldPoint(mouse);
        }
        if (Input.GetMouseButton(1) && gettingButterfly)
        {
            gettingButterfly = false;
        }
    }
    private void OnMouseDown()
    {
        //float dist = Vector3.Distance(player.position, transform.position);
        if (gettingButterfly == false)
        {
            Vector3 mouse = Input.mousePosition;
            mouse.z = 10;
            prePos = Camera.main.ScreenToWorldPoint(mouse);

            gettingButterfly = true;
            //item.GetComponent<Rigidbody>().useGravity = false;
        }
    }
}
