using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class spiderLocker : MonoBehaviour {
    public GameObject item;
    public GameObject girlC;
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    public static Transform player;
    public static bool spiderKeyOpen = false;

    void Awake()
    {
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void OnMouseDown()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        if (spiderKeyGetting.gettingSpider && dist <= 30)
        {
            Vector3 spiderKeyPosition = new Vector3(1151.76f, -45.22f, -76.29f);
            item.transform.position = spiderKeyPosition;
            item.transform.rotation = Quaternion.Euler(90, 0, 0);
            spiderKeyGetting.gettingSpider = false;
            spiderKeyGetting.canGetThis = false;
            spiderKeyGetting.spiderKey.transform.SetParent(girlC.transform, true);
            spiderKeyGetting.spiderKey.GetComponent<Rigidbody>().isKinematic = false;
            spiderKeyGetting.spiderKey.GetComponent<Rigidbody>().detectCollisions = false;
            talkFlowchart.ExecuteBlock(talkFlowchart.FindBlock("spiderKeyOpen"));
            spiderKeyOpen = true;
        }
    }
}
