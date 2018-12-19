using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class spiderMouth : MonoBehaviour
{
    public GameObject item;
    public GameObject candyHouse;
    public static bool cicadaInSpider = false;
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    public static Transform player;
    private void Awake()
    {
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    public static bool isTalking
    {
        get { return flowchartManager.GetBooleanVariable("talking"); }
    }
    private void OnMouseDown()
    {
        float dist = Vector3.Distance(player.transform.position, transform.position);
        if (cicadaKeyGetting.gettingCicada && dist <= 30 && !isTalking)
        {
            Vector3 cicadaPosition = new Vector3(1259.859f, -64.87f, 212.97f);
            item.transform.rotation = Quaternion.Euler(0, 0, 0);
            item.transform.position = cicadaPosition;
            cicadaKeyGetting.gettingCicada = false;
            cicadaKeyGetting.canGetThis = false;
            cicadaKeyGetting.cicadaKey.transform.SetParent(candyHouse.transform, true);
            cicadaInSpider = true;
            talkFlowchart.ExecuteBlock("candyToCastle");
        }
    }
}
