using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class tanglangLocker : MonoBehaviour {
    public GameObject item;
    public GameObject girlC;
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    public static Transform player;
    public static bool tanglangKeyOpen = false;

    void Awake()
    {
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void Update()
    {
        if (glassRightUp.tanglangInSpec)
        {
            item.SetActive(true);
        }
    }

    private void OnMouseDown()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        if (gettingTanglangKey.gettingTanglang && dist <= 30)
        {
            gettingTanglangKey.tanglangKey.transform.SetParent(girlC.transform, true);
            Vector3 tanglangKeyPosition = new Vector3(1171.864f, -44.22f, -74.7f);
            item.transform.position = tanglangKeyPosition;
            item.transform.rotation = Quaternion.Euler(90, 0, 180);
            gettingTanglangKey.gettingTanglang = false;
            gettingTanglangKey.canGetThis = false;
            gettingTanglangKey.tanglangKey.GetComponent<Rigidbody>().isKinematic = false;
            talkFlowchart.ExecuteBlock(talkFlowchart.FindBlock("tanglangKeyOpen"));
            tanglangKeyOpen = true;
        }
    }
}
