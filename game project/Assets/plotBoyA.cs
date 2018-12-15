using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plotBoyA : MonoBehaviour {
    public GameObject bottle1;
    public GameObject paperInBottle;
    public bool ya = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (endPaper.pickUpEndPaper)
        {
            bottle1.SetActive(true);
            paperInBottle.SetActive(false);
        }
        if (bottle.gettingBottle){
            paperInBottle.SetActive(true);
            ya = true;
        }
        if (ya){
            paperInBottle.SetActive(true);
        }
    }
}
