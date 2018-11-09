using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getItem : MonoBehaviour {
    private void OnMouseDown()
    {
        Destroy(GameObject.FindGameObjectWithTag("item"));
    }

}
