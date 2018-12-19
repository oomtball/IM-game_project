using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class laser : MonoBehaviour {
    public GameObject player;
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    int flag = 0;
    // Use this for initialization
    private void Awake()
    {
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
    }
    public static bool back
    {
        get { return talkFlowchart.GetBooleanVariable("back"); }
    }
    // Update is called once per frame
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player.transform.position = new Vector3(57.32f, 173, -72.76f);
            if (flag == 0)
            {
                talkFlowchart.ExecuteBlock("goBack");
                flag = 1;
            }
            else if (!back){
                flag = 0;
            }
        }
    }
}
