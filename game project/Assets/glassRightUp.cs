using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glassRightUp : MonoBehaviour {
    public GameObject item;
    public Transform item2;
    private void OnMouseDown()
    {
        if (tanglangGetting.gettingTanglang)
        {
            Vector3 tanglangPosition = new Vector3(-83, 195.8f, -187.91f);
            item.transform.position = tanglangPosition;
            getItem.isGettingItem = false;
        }
    }
}
