using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class butterflyLocker : MonoBehaviour {
    public GameObject item;
    public GameObject girlC;
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    public static Transform player;
    public static bool butterflyOpen = false;

    void Awake()
    {
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        if (goldenButterfly.butterflyInSpecimen){
            item.SetActive(true);
        }
    }

    public static bool butterInSpecimen
    {
        get { return talkFlowchart.GetBooleanVariable("butterInSpecimen"); }
    }

    private void Update()
    {
        if (butterInSpecimen)
        {
            item.SetActive(true);
        }
    }

    private void OnMouseDown()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        if (butterKeyGetting.gettingButterfly && dist <= 30)
        {
            Vector3 butterflyKeyPosition = new Vector3(1151.824f, -64.5f, -75.60059f);
            butterKeyGetting.butterKey.transform.SetParent(girlC.transform, true);
            butterKeyGetting.butterKey.GetComponent<Rigidbody>().isKinematic = false;
            butterKeyGetting.butterKey.GetComponent<Rigidbody>().detectCollisions = false;
            item.transform.position = butterflyKeyPosition;
            item.transform.rotation = Quaternion.Euler(90, 0, 0);
            butterKeyGetting.gettingButterfly = false;
            butterKeyGetting.canGetThis = false;
            talkFlowchart.ExecuteBlock(talkFlowchart.FindBlock("butterKeyOpen"));
            butterflyOpen = true;
        }
    }
}
