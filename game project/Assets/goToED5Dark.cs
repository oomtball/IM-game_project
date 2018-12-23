using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.SceneManagement;

public class goToED5Dark : MonoBehaviour
{
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;

    void Awake()
    {
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
    }

    public static bool isTalking
    {
        get { return flowchartManager.GetBooleanVariable("talking"); }
    }

    public static bool isChoosing
    {
        get { return flowchartManager.GetBooleanVariable("choosing"); }
    }

    public static bool goToED5
    {
        get { return talkFlowchart.GetBooleanVariable("goToED5"); }
    }

    private void Update()
    {
        if (goToED5){
            SceneManager.LoadScene("ED5Dark");
        }
    }
}
