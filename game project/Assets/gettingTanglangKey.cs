using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gettingTanglangKey : MonoBehaviour {
    public static Transform player;
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
        //body = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (gettingTanglang && canGetThis)
        {
            Vector3 mouse = Input.mousePosition;
            mouse.z = 10;
            Vector3 newPos = Camera.main.ScreenToWorldPoint(mouse);
            Vector3 offset = newPos - prePos;
            transform.position += offset;
            prePos = Camera.main.ScreenToWorldPoint(mouse);
        }
        if (Input.GetMouseButton(1) && gettingTanglang)
        {
            gettingTanglang = false;
        }
    }
    private void OnMouseDown()
    {
        //float dist = Vector3.Distance(player.position, transform.position);
        if (gettingTanglang == false)
        {
            Vector3 mouse = Input.mousePosition;
            mouse.z = 10;
            prePos = Camera.main.ScreenToWorldPoint(mouse);

            gettingTanglang = true;
            //item.GetComponent<Rigidbody>().useGravity = false;
        }
    }
}
