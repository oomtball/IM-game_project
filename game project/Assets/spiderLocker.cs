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
            spiderKeyGetting.spiderKey.transform.SetParent(girlC.transform, true);
            Vector3 spiderKeyPosition = new Vector3(1151.83f, -44.6346f, -74.0697f);
            item.transform.position = spiderKeyPosition;
            item.transform.rotation = Quaternion.Euler(-90, 0, 0);
            spiderKeyGetting.gettingSpider = false;
            spiderKeyGetting.canGetThis = false;
            spiderKeyGetting.spiderKey.GetComponent<Rigidbody>().isKinematic = false;
            spiderKeyGetting.spiderKey.GetComponent<Rigidbody>().detectCollisions = false;
            talkFlowchart.ExecuteBlock(talkFlowchart.FindBlock("spiderKeyOpen"));
            spiderKeyOpen = true;
        }
        if (gettingTanglangKey.gettingTanglang || butterKeyGetting.gettingButterfly && dist <= 30){
            butterKeyGetting.canGetThis = true;
            butterKeyGetting.gettingButterfly = false;
            gettingTanglangKey.canGetThis = true;
            gettingTanglangKey.gettingTanglang = false;
            talkFlowchart.ExecuteBlock("wrongKey");
        }
    }
}
