using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class cicadaKeyGetting : MonoBehaviour {
    public static Transform player;
    public static bool gettingCicada = false;
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    public static GameObject pivot;
    public static GameObject goal;
    public GameObject girlC;
    public static GameObject cicadaKey;
    public static bool canGetThis = true;
    Vector3 prePos;
    //Rigidbody body;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        pivot = GameObject.Find("pivot");
        goal = GameObject.Find("goal");
        cicadaKey = GameObject.Find("cicadaKey");
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
        cicadaKey.SetActive(false);
    }
    private void Update()
    {
        if (gettingCicada && canGetThis)
        {
            cicadaKey.transform.SetParent(pivot.transform, true);
        }
        if (Input.GetMouseButton(1) && gettingCicada)
        {
            gettingCicada = false;
            cicadaKey.transform.SetParent(girlC.transform, true);
            cicadaKey.GetComponent<Rigidbody>().useGravity = true;
            cicadaKey.GetComponent<Rigidbody>().isKinematic = false;
            cicadaKey.GetComponent<Rigidbody>().detectCollisions = true;
        }
    }
    private void OnMouseDown()
    {
        talkFlowchart.ExecuteBlock("getCicadaKey");
        float dist = Vector3.Distance(player.position, transform.position);
        if (gettingCicada == false && dist <= 30 && canGetThis)
        {
            cicadaKey.transform.position = goal.transform.position;
            cicadaKey.GetComponent<Rigidbody>().useGravity = false;
            gettingCicada = true;
            cicadaKey.GetComponent<Rigidbody>().isKinematic = true;
            cicadaKey.GetComponent<Rigidbody>().detectCollisions = false;
        }
    }
}
