using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class cicadaLocker : MonoBehaviour {
    public GameObject item;
    public GameObject girlC;
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    public static Transform player;
    public static bool cicadaOpen = false;

    void Awake()
    {
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void Update()
    {
        if (finalTrapOpen.finish)
        {
            item.SetActive(true);
        }
    }

    private void OnMouseDown()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        if (cicadaKeyGetting.gettingCicada && dist <= 30)
        {
            Vector3 cicadaKeyPosition = new Vector3(1161.944f, -55.73f, -76.04058f);
            cicadaKeyGetting.cicadaKey.transform.position = cicadaKeyPosition;
            cicadaKeyGetting.cicadaKey.transform.rotation = Quaternion.Euler(90, 0, 0);
            cicadaKeyGetting.gettingCicada = false;
            cicadaKeyGetting.canGetThis = false;
            cicadaKeyGetting.cicadaKey.transform.SetParent(girlC.transform, true);
            talkFlowchart.ExecuteBlock(talkFlowchart.FindBlock("cicadaKeyOpen"));
            cicadaOpen = true;
        }
    }
}
