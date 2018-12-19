using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;

public class goToED2Dark : MonoBehaviour
{
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    private bool isAct = false;
    // Start is called before the first frame update
    void Start()
    {
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
    }
    public static bool goToED2
    {
        get { return talkFlowchart.GetBooleanVariable("goToED2"); }
    }
    // Update is called once per frame
    void Update()
    {
        if (goToED2)
        {
            SceneManager.LoadScene("ED2Dark");
        }
    }
}
