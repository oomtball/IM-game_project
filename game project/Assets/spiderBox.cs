using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class spiderBox : MonoBehaviour {
    public Flowchart spiderFlowchart;
    private void OnMouseDown()
    {
        spiderFlowchart.ExecuteBlock("spiderHead");
    }
}
