using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;

public class plotLab : MonoBehaviour
{
    public GameObject cube1;
    public static Transform player;
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    private bool isAct = false;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
    }
    public static bool goToED2Gallery
    {
        get { return talkFlowchart.GetBooleanVariable("goToED2Gallery"); }
    }
    public static bool candyToCastle
    {
        get { return talkFlowchart.GetBooleanVariable("candyToCastle"); }
    }
    public static bool labFail
    {
        get { return talkFlowchart.GetBooleanVariable("labFail"); }
    }
    // Update is called once per frame
    void Update()
    {
        if (cicadaLocker.cicadaOpen && !isAct)
        {
            cube1.SetActive(true);
            isAct = true;
        }
        if (goToED2Gallery){
            SceneManager.LoadScene("ED2");
        }
        if (candyToCastle)
        {
            SceneManager.LoadScene("candyToCastle");
        }
        if (labFail){
            player.position = new Vector3(-158.75f, 187.4f, -160.9f);
        }
    }
}
