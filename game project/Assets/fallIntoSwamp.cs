using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class fallIntoSwamp : MonoBehaviour
{
    public static Flowchart talkFlowchart;
    public static Transform player;
    // Start is called before the first frame update
    void Awake()
    {
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")){
            talkFlowchart.ExecuteBlock("fallIntoSwamp");
        }
    }
}
