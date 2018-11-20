using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notebookOpen : MonoBehaviour {

    public GameObject notebook;
    public static bool bookOpen = false;
   
    void Update () {
        if (Input.GetKeyDown(KeyCode.M) && bookOpen == false){
            notebook.SetActive(true);
            bookOpen = true;
        }
        else if(Input.GetKeyDown(KeyCode.M) && bookOpen == true)
        {
            notebook.SetActive(false);
            bookOpen = false;
        }

    }
}
