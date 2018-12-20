using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;

public class backToGallery : MonoBehaviour {
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    public static Transform player;
    private void Awake()
    {
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    public static bool isTalking
    {
        get { return flowchartManager.GetBooleanVariable("talking"); }
    }

    public static bool isChoosing
    {
        get { return flowchartManager.GetBooleanVariable("choosing"); }
    }
    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.B)){
            if (!isTalking && !isChoosing)
                player.position = new Vector3(124.7f, 491.5f, 719.9f);
        }
    }
}
