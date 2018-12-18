using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.SceneManagement;

public class plotBoyA : MonoBehaviour {
    public GameObject bottle1;
    public GameObject paperInBottle;
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    public bool ya = false;
    // Use this for initialization
    void Start () {
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
    }
    public static bool isTalking
    {
        get { return flowchartManager.GetBooleanVariable("talking"); }
    }

    public static bool isChoosing
    {
        get { return flowchartManager.GetBooleanVariable("choosing"); }
    }
    public static bool endBoyA
    {
        get { return talkFlowchart.GetBooleanVariable("endBoyA"); }
    }
    // Update is called once per frame
    void Update () {
        if (endPaper.pickUpEndPaper)
        {
            bottle1.SetActive(true);
            paperInBottle.SetActive(false);
        }
        if (bottle.gettingBottle){
            paperInBottle.SetActive(true);
            ya = true;
        }
        if (ya){
            paperInBottle.SetActive(true);
        }
        if (endBoyA){
            SceneManager.LoadScene("ED3");
        }
    }
}
