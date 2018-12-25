using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class endPaperAppear : MonoBehaviour {
    public GameObject endPaperYa;
	// Use this for initialization
    void start () {
        
    }
	// Update is called once per frame
	void Update () {
        if (startPaper.pickUpStartPaper && paper1.pickUpPaper1 && paper2.pickUpPaper2 && paper3.pickUpPaper3
            && paper4.pickUpPaper4 && paper5.pickUpPaper5 && paper6.pickUpPaper6){
            endPaperYa.SetActive(true);
        }
	}
}
