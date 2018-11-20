﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class test : MonoBehaviour
{
    public GameObject item;
    public GameObject tempParent;
    public Transform guide;

    void Start()
    {
        item.GetComponent<Rigidbody>().useGravity = true;
    }
    private void Update()
    {

    }
    private void OnMouseDown()
    {
        item.GetComponent<Rigidbody>().useGravity = false;
        item.GetComponent<Rigidbody>().isKinematic = true;
        item.transform.position = guide.transform.position;
        item.transform.rotation = guide.transform.rotation;
        item.transform.parent = tempParent.transform;
    }
    private void OnMouseUp()
    {
        item.GetComponent<Rigidbody>().useGravity = true;
        item.GetComponent<Rigidbody>().isKinematic = false;
        item.transform.position = guide.transform.position;
        item.transform.parent = null;
    }
}