using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class glassRightUp : MonoBehaviour {
    public GameObject item;
    public Transform player;
    public GameObject lab;
    public static GameObject locust;
    public static GameObject moth;
    public static bool tanglangInSpec = false;
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    private void Awake()
    {
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
        locust = GameObject.Find("Locust");
        moth = GameObject.Find("moth");
    }
    public static bool isTalking
    {
        get { return flowchartManager.GetBooleanVariable("talking"); }
    }
    private void OnMouseDown()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        if (tanglangGetting.gettingTanglang && dist <= 30 && !isTalking)
        {
            Vector3 tanglangPosition = new Vector3(-80.17f, 200.06f, -181.9482f);
            item.transform.rotation = Quaternion.Euler(0, 0, 0);
            item.transform.position = tanglangPosition;
            tanglangGetting.gettingTanglang = false;
            tanglangGetting.canGetThis = false;
            tanglangGetting.tanglang.transform.SetParent(lab.transform, true);
            tanglangInSpec = true;
            Destroy(locust);
            Destroy(moth);
            talkFlowchart.ExecuteBlock("tanglangTalk");
        }
    }
}
