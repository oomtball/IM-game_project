using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class gameManager : MonoBehaviour {
    // Use this for initialization
    static gameManager instance;
    public static Flowchart flowchartManager;
    public static Flowchart talkFlowchart;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
            name = "initial game manager";
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
    }
}
