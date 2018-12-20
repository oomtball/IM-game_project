using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class sword : MonoBehaviour
{
    public static Transform player;
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    int flag = 0;
    int flag2 = 0;
    // Use this for initialization
    private void Awake()
    {
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    public static bool back
    {
        get { return talkFlowchart.GetBooleanVariable("back"); }
    }
    private void Update()
    {
        if (!back)
        {
            flag = 0;
        }
    }
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.transform.position = new Vector3(57.32f, 173, -72.76f);
            if (flag == 0)
            {
                talkFlowchart.ExecuteBlock("goBack");
                flag = 1;
                flag2 = 1;
            }
            else if (!back)
            {
                flag = 0;
                flag2 = 0;
            }
        }
    }
}
